using Groups.Implementions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Groups.Tests;

[TestClass]
public class GroupManagerEntityTests
{
    [TestMethod]
    public void GroupManagerEntity_Create_ShouldAddGroup()
    {
        // Arrange
        var groupManager = new GroupManagerEntity();
        var group = new GroupEntity(1, "Group 1", 2022);

        // Act
        groupManager.Create(group);

        // Assert
        Assert.AreEqual(1, groupManager.Groups.Count);
        Assert.IsTrue(groupManager.Groups.Contains(group));
    }
}