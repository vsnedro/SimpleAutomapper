namespace SimpleAutoMapper.Example;

internal class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id = {Id}; Name = {Name}; Email = {Email};";
    }
}

internal class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id = {Id}; Name = {Name}; Email = {Email};";
    }
}
