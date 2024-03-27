namespace Groups.Implementions;

public class PersonEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public PersonEntity(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}