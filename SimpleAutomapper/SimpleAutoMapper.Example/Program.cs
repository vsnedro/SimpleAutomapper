using BenchmarkDotNet.Running;

using SimpleAutoMapper.Example;
using SimpleAutoMapper.Benchmarks;
using SimpleAutoMapper;

var mapper = new SimpleMapper<Person, User>();
var alexPerson = new Person() { Id = 1, Name = "Alex", Email = "alex@local" };
Console.WriteLine($"Alex as person: {alexPerson}");
var alexUser = mapper.Map(alexPerson);
Console.WriteLine($"Alex as user: {alexUser}");

BenchmarkRunner.Run<SimpleMapperBenchmark>();

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();
