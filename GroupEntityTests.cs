using Groups.Implementions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Groups.Tests;

[TestClass]
public class GroupEntityTests
{
    [TestMethod]
    public void GroupEntity_Initialization_ShouldSucceed()
    {
        // Arrange
        var group = new GroupEntity(1, "Group 1", 2022);

        // Assert
        Assert.IsNotNull(group);
        Assert.AreEqual(1, group.Id);
        Assert.AreEqual("Group 1", group.Name);
        Assert.AreEqual(2022, group.CreatedYear);
        Assert.IsNotNull(group.Students);
        Assert.IsInstanceOfType(group.Students, typeof(List<StudentEntity>));
    }
}