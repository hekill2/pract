using Groups.Implementions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Groups.Tests;

[TestClass]
public class StudentEntityTests
{
    [TestMethod]
    public void StudentEntity_Initialization_ShouldSucceed()
    {
        // Arrange
        var student = new StudentEntity(1, "Alice Smith", "alice@example.com");

        // Assert
        Assert.IsNotNull(student);
        Assert.AreEqual(1, student.Id);
        Assert.AreEqual("alice@example.com", student.Email);
        Assert.AreEqual("Alice Smith", student.Name);
    }
}