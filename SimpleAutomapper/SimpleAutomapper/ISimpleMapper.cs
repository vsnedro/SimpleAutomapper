namespace SimpleAutoMapper
{
    public interface ISimpleMapper<TSource, TDestination>
        where TSource : class, new()
        where TDestination : class, new()
    {
        public TDestination Map(TSource source);
    }
}
