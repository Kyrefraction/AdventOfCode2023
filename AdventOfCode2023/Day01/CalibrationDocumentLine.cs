using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentLine(string line)
{
    private readonly string _lineDigits = line.ParseDigits();

    public int ConcatenatedFirstAndLastDigit()
    {
        var firstAndLastDigits = $"{_lineDigits.GetFirstCharacter()}{_lineDigits.GetLastCharacter()}";
        return firstAndLastDigits.ToInt();
    }
}