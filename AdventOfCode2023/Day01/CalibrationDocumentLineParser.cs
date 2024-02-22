using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public static class CalibrationDocumentLineParser
{
    private static readonly Dictionary<string, char> Numbers = new()
    {
        {
            "one", '1'
        },
        {
            "two", '2'
        },
        {
            "three", '3'
        },
        {
            "four", '4'
        },
        {
            "five", '5'
        },
        {
            "six", '6'
        },
        {
            "seven", '7'
        },
        {
            "eight", '8'
        },
        {
            "nine", '9'
        }
    };

    public static string Parse(string line)
    {
        var parsedLine = "";
        for (var index = 0; index < line.Length; index++)
        {
            if (char.IsDigit(line[index]))
            {
                parsedLine += line[index];
            }
            else
            {
                foreach (var number in Numbers)
                {
                    if (number.Key == line.SafeSubstring(index, number.Key.Length))
                    {
                        parsedLine += number.Value;
                    }
                }    
            }
        }
        
        return parsedLine;
    }
}