using System.Text;

namespace CodingChallenge;

public class OldPhonePadConverter
{
    private readonly Dictionary<char, char[]> _keypadMapping = new Dictionary<char, char[]>()
    {
        { '2', new char[] { 'A', 'B', 'C' }},
        { '3', new char[] { 'D', 'E', 'F' }},
        { '4', new char[] { 'G', 'H', 'I' }},
        { '5', new char[] { 'J', 'K', 'L' }},
        { '6', new char[] { 'M', 'N', 'O' }},
        { '7', new char[] { 'P', 'Q', 'R', 'S' }},
        { '8', new char[] { 'T', 'U', 'V' }},
        { '9', new char[] { 'W', 'X', 'Y', 'Z' }}
    };

    public string OldPhonePad(string input)
    {
        var output = new StringBuilder();
        var previousChar = ' ';
        foreach (var currentChar in input)
        {
            if (char.IsDigit(currentChar)) {
                if (previousChar == currentChar) {
                    output.Append(' ');
                }
                var keyIndex = int.Parse(currentChar.ToString()) - 2;
                var keyChars = _keypadMapping[currentChar];
                output.Append(keyChars[keyChars.Length - 1]);
            } else if (currentChar == '*') {
                output.Append('*');
            } else if (currentChar == '#') {
                output.Append('#');
            } else {
                output.Append(' ');
            }
            previousChar = currentChar;
        }
        return output.ToString().Trim();
    }
}