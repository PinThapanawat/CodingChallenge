using CodingChallenge.Factories;
using CodingChallenge.Models;
using CodingChallenge.Services;
using NUnit.Framework;

namespace CodingChallenge.Tests;

public class PhonePadToTextConverterTests
{
    private PhonePadConverter _converter;
    [SetUp]
    public void Setup()
    {
        var keypadMapping = new DefaultKeypadMapping();
        var phonePadToTextConverter = new PhonePadToTextConverter(keypadMapping);
        _converter = new PhonePadConverter(phonePadToTextConverter);
    }

    [Test]
    [TestCase("33#", "E")]
    [TestCase("227*#", "B")]
    [TestCase("4433555 555666#", "HELLO")]
    [TestCase("8 88777444666*664#", "?????")]
    public void TestOldPhonePad_ShouldBe_Pass(string input, string expectedOutput)
    {
        var actualOutput = _converter.Convert(input);
        Assert.AreEqual(expectedOutput, actualOutput);
    }

}