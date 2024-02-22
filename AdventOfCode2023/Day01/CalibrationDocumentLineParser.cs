namespace AdventOfCode2023.Day01;

public static class CalibrationDocumentLineParser
{
    private static readonly Dictionary<string, int> Numbers = new()
    {
        {
            "one", 1
        },
        {
            "two", 2
        },
        {
            "three", 3
        },
        {
            "four", 4
        },
        {
            "five", 5
        },
        {
            "six", 6
        },
        {
            "seven", 7
        },
        {
            "eight", 8
        },
        {
            "nine", 9
        }
    };

    public static string Parse(string line)
    {
        var parsedLine = "";
        for (var index = 0; index < line.Length; index++)
        {
            var singleCharacter = line.Substring(index, 1);
            if (char.IsDigit(singleCharacter.ToCharArray().First()))
            {
                parsedLine += singleCharacter;
            }
            else
            {
                foreach (var number in Numbers)
                {
                    var remainingLineLength = line.Length - index;
                    var numberLength = number.Key.Length;
            
                    if (line.Substring(index, remainingLineLength < numberLength ? remainingLineLength : numberLength) == number.Key)
                    {
                        parsedLine += number.Value;
                    }    
                }   
            }
        }

        return parsedLine;
    }
}