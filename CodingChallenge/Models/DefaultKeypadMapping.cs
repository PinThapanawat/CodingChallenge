using CodingChallenge.Interfaces;

namespace CodingChallenge.Models;

public class DefaultKeypadMapping : IKeypadMapping
{
    public string GetLetters(char digit)
    {
        return digit switch
        {
            '2' => "ABC",
            '3' => "DEF",
            '4' => "GHI",
            '5' => "JKL",
            '6' => "MNO",
            '7' => "PQRS",
            '8' => "TUV",
            '9' => "WXYZ",
            '#' => "",
            _ => "?"
        };
    }
}
