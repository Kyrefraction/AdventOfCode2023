using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentLine(string line)
{
    private readonly string _line = line.ParseDigits();

    public int ConcatenatedFirstAndLastDigit()
    {
        var firstAndLastDigits = $"{_line.GetFirstCharacter()}{_line.GetLastCharacter()}";
        return firstAndLastDigits.ToInt();
    }
}