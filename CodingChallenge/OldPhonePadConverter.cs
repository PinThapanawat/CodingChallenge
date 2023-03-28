using System.Text;
using System.Text.RegularExpressions;

namespace CodingChallenge;

public class OldPhonePadConverter
{
    private readonly Dictionary<char, string> _keypadMapping = new()
    {
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '#', "" }
    };

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

            var letters = _keypadMapping.GetValueOrDefault(currentChar, "?");

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