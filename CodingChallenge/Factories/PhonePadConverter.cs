using CodingChallenge.Interfaces;

namespace CodingChallenge.Factories;

public class PhonePadConverter
{
    private readonly IPhonePadConverter _phonePadConverter;

    public PhonePadConverter(IPhonePadConverter phonePadConverter)
    {
        _phonePadConverter = phonePadConverter;
    }

    public string Convert(string input)
    {
        return _phonePadConverter.Convert(input);
    }
}