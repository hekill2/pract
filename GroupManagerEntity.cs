using Students.Implementations;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    public List<GroupEntity> Groups { get; private set; }

    public GroupManagerEntity()
    {
        Groups = new List<GroupEntity>();
    }

    public void Create(GroupEntity group)
    {
        Groups.Add(group);
    }
}