using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students.Implementations;

namespace Groups.Tests;

[TestClass]
public class TeacherEntityTests
{
    [TestMethod]
    public void TeacherEntity_Initialization_ShouldSucceed()
    {
        // Arrange
        var teacher = new TeacherEntity(1, "John Doe", "john.doe@gmail.com");

        // Assert
        Assert.IsNull(teacher);
        Assert.AreEqual(1, teacher?.Id);
        Assert.AreEqual("John Doe", teacher?.Name);
    }
}