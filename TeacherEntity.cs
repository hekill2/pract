using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public List<SubjectEntity> Subjects { get; private set; }

    public TeacherEntity(int id, string name, string email) : base(id, name, email)
    {
        Subjects = new List<SubjectEntity>();
    }
}