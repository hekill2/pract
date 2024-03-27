
using Groups.Implementions;

namespace Groups.Implementions;

public class GroupEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CreatedYear { get; set; }
    public List<StudentEntity> Students { get; set; }

    public GroupEntity(int id, string name, int year)
    {
        Id = id;
        Name = name;
        CreatedYear = year;
        Students = new List<StudentEntity>();
    }

}
