using NUnit.Framework;

namespace CodingChallenge.Tests;

public class OldPhonePadConverterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("33#", "E")]
    [TestCase("227*#", "B")]
    [TestCase("4433555 555666#", "HELLO")]
    [TestCase("8 88777444666*664#", "?????")]
    public void TestOldPhonePad_ShouldBe_Pass(string input, string expectedOutput)
    {
        var converter = new OldPhonePadConverter();
        var actualOutput =  converter.OldPhonePad(input);
        Assert.AreEqual(expectedOutput, actualOutput);
    }

}