namespace Groups.Implementions;

public class SubjectEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public SubjectEntity(int id, string name)
    {
        Id = id;
        Name = name;
    }
}