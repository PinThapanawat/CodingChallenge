using NUnit.Framework;

namespace CodingChallenge.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldBePass()
    {
        var converter = new OldPhonePadConverter();
        var result =  converter.OldPhonePad("33#");
        Assert.Equals(result, "E");

    }
}