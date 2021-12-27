using System.Collections.Generic;

using AutoMapper;

using BenchmarkDotNet.Attributes;

using SimpleAutoMapper;
using SimpleAutoMapper.Benchmarks.Models;

namespace SimpleAutoMapper.Benchmarks;

public class SimpleMapperBenchmark
{
    private const int MaxIterations = 10_000;
    private const int loop100 = 100;
    private const int loop1K = 1_000;
    private const int loop10K = 10_000;

    private List<SourceObject> _sources;

    public SimpleMapperBenchmark()
    {
        Initialize();
    }

    [Benchmark(Description = "SimpleMapper100")]
    public void TestSimpleMapper100()
    {
        const int iterations = loop100;
        var mapper = new SimpleMapper<SourceObject, DestinationObject>();
        for (var i = 0; i < iterations; i++)
        {
            mapper.Map(_sources[i]);
        }
    }

    [Benchmark(Description = "SimpleMapper1K")]
    public void TestSimpleMapper1K()
    {
        const int iterations = loop1K;
        var mapper = new SimpleMapper<SourceObject, DestinationObject>();
        for (var i = 0; i < iterations; i++)
        {
            mapper.Map(_sources[i]);
        }
    }

    [Benchmark(Description = "SimpleMapper10K")]
    public void TestSimpleMapper10K()
    {
        const int iterations = loop10K;
        var mapper = new SimpleMapper<SourceObject, DestinationObject>();
        for (var i = 0; i < iterations; i++)
        {
            mapper.Map(_sources[i]);
        }
    }

    [Benchmark(Description = "AutoMapper100")]
    public void TestAutoMapper100()
    {
        const int iterations = loop100;
        var config = new MapperConfiguration(cfg => cfg.CreateMap<SourceObject, DestinationObject>());
        var mapper = new Mapper(config);
        for (var i = 0; i < iterations; i++)
        {
            mapper.Map<DestinationObject>(_sources[i]);
        }
    }

    [Benchmark(Description = "AutoMapper1K")]
    public void TestAutoMapper1K()
    {
        const int iterations = loop1K;
        var config = new MapperConfiguration(cfg => cfg.CreateMap<SourceObject, DestinationObject>());
        var mapper = new Mapper(config);
        for (var i = 0; i < iterations; i++)
        {
            mapper.Map<DestinationObject>(_sources[i]);
        }
    }

    [Benchmark(Description = "AutoMapper10K")]
    public void TestAutoMapper10K()
    {
        const int iterations = loop10K;
        var config = new MapperConfiguration(cfg => cfg.CreateMap<SourceObject, DestinationObject>());
        var mapper = new Mapper(config);
        for (var i = 0; i < iterations; i++)
        {
            mapper.Map<DestinationObject>(_sources[i]);
        }
    }

    private void Initialize()
    {
        if (_sources == null)
        {
            _sources = new List<SourceObject>(MaxIterations);
            for (int i = 0; i < MaxIterations; i++)
            {
                _sources.Add(new SourceObject());
            }
        }
    }
}
