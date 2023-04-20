using CodingChallenge.Interfaces;

namespace CodingChallenge.Services;
public class PhonePadToTextConverter : IPhonePadConverter
{
    private readonly IKeypadMapping _keypadMapping;

    public PhonePadToTextConverter(IKeypadMapping keypadMapping)
    {
        _keypadMapping = keypadMapping;
    }

    public string Convert(string input)
    {
        var output = "";
        var i = 0;

        while (i < input.Length - 1)
        {
            var currentChar = input[i];

            if (currentChar == ' ')
            {
                output += ' ';
                i++;
                continue;
            }

            var currentCharCount = 1;
            while (i < input.Length - 1 && input[i + 1] == currentChar)
            {
                i++;
                currentCharCount++;
            }

            var letters = _keypadMapping.GetLetters(currentChar);

            if (letters.Length > 0)
            {
                var index = (currentCharCount - 1) % letters.Length;
                output += letters[index];
            }

            i++;
        }

        var markingIndex = output.IndexOf('?');
        output = output.Replace(" ", "");

        if (!output.Contains('?')) return output;

        output = markingIndex == output.Length - 1
            ? output.Remove(markingIndex - 1, 2)
            : new string('?', markingIndex - 1);

        return output;
    }
}

