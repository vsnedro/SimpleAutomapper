using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SimpleAutoMapper
{
    public class SimpleMapper<TSource, TDestination> : ISimpleMapper<TSource, TDestination>
        where TSource : class, new()
        where TDestination : class, new()
    {
        private const BindingFlags publicMembersAttrs = BindingFlags.Public | BindingFlags.Instance;

        private Action<TSource, TDestination> _mapExpression = null;

        public TDestination Map(TSource source)
        {
            if (source == null) return null;

            var destination = new TDestination();
            // Execute the lambda expression.
            GetMapExpression()?.Invoke(source, destination);

            return destination;
        }

        private Action<TSource, TDestination> GetMapExpression()
        {
            if (_mapExpression == null)
            {
                _mapExpression = PrepareMapExpression();
            }
            return _mapExpression;
        }

        private Action<TSource, TDestination> PrepareMapExpression()
        {
            var sourceMembers = GetSourceReadableMembers();
            var destinationMembers = GetDestinationWritableMembers();
            var mapExpression = CreateMapExpression(sourceMembers, destinationMembers);

            // Compile the lambda expression into executable code.
            return mapExpression.Compile();
        }

        private static IEnumerable<MemberInfo> GetSourceReadableMembers()
        {
            static bool GetReadableMembers(MemberInfo m) =>
                (m.MemberType == MemberTypes.Field) ||
                (m.MemberType == MemberTypes.Property && m is PropertyInfo p && p.CanRead);

            return typeof(TSource).GetMembers(publicMembersAttrs)
                .Where(GetReadableMembers)
                .ToList();
        }

        private static IEnumerable<MemberInfo> GetDestinationWritableMembers()
        {
            static bool GetWritableMembers(MemberInfo m) =>
                 (m.MemberType == MemberTypes.Field && m is FieldInfo f && !f.IsInitOnly && !f.IsLiteral) ||
                 (m.MemberType == MemberTypes.Property && m is PropertyInfo p && p.CanWrite);

            return typeof(TDestination).GetMembers(publicMembersAttrs)
                .Where(GetWritableMembers)
                .ToList();
        }

        private static Expression<Action<TSource, TDestination>> CreateMapExpression(
            IEnumerable<MemberInfo> sourceMembers, IEnumerable<MemberInfo> destinationMembers)
        {
            var memberPairs = sourceMembers
                .Join(destinationMembers,
                    src => src.Name.ToLowerInvariant(),
                    dest => dest.Name.ToLowerInvariant(),
                    (src, dest) => new { SourceMember = src, DestinationMember = dest })
                .ToList();

            // Create parameters for the expression tree.
            var srcParamExpr = Expression.Parameter(typeof(TSource), "source");
            var destParamExpr = Expression.Parameter(typeof(TDestination), "destination");
            var expressions = new List<BinaryExpression>(memberPairs.Count());

            foreach (var pair in memberPairs)
            {
                var srcPropExpr = Expression.PropertyOrField(srcParamExpr, pair.SourceMember.Name);
                var destPropExpr = Expression.PropertyOrField(destParamExpr, pair.DestinationMember.Name);
                var assignExpr = Expression.Assign(destPropExpr, srcPropExpr);
                expressions.Add(assignExpr);
            }

            var expressionBody = Expression.Block(expressions);
            // The expression tree to execute.
            var actionExpression = Expression.Lambda<Action<TSource, TDestination>>(
                expressionBody,
                new ParameterExpression[] { srcParamExpr, destParamExpr, });

            return actionExpression;
        }
    }
}
