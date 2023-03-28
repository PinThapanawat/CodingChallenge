using System.Text;

namespace CodingChallenge;

public class OldPhonePadConverter
{
    private readonly Dictionary<char, string> _keypadMapping = new Dictionary<char, string>
    {
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '*', "" }
    };

    public string OldPhonePad(string input)
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

            var currentCharCount = '1';

            while (i < input.Length - 1 && input[i + 1] == currentChar)
            {
                i++;
                currentCharCount++;
                System.Threading.Thread.Sleep(1000);
            }

            var letters = _keypadMapping[currentChar];
            if (letters.Length > 0)
            {
                var index = (currentCharCount - '0' - 1) % letters.Length;
                output += letters[index];
            }
            else
            {
                output = output.Remove(output.Length - 1, 1);
            }

            i++;
        }

        return output.Replace(" ", "");
    }
}