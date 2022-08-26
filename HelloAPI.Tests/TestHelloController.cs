using HelloAPI.Controllers;
using Microsoft.Extensions.Logging;
using NSubstitute;
using NUnit.Framework;

namespace HelloAPI.Tests;

[TestFixture]
public class TestHelloController
{
    [Test]
    public void Get_ShouldReturnHelloAndName()
    {
        // Arrange
        var logger = Substitute.For<ILogger<HelloController>>();
        var controller = new HelloController(logger);
        var expected = "Hello Bob";

        // Act
        var result = controller.Get("Bob");

        // Assert
        Assert.AreEqual(expected, result);
    }
}