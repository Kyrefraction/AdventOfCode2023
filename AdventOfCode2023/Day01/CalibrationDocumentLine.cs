using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentLine(string line)
{
    private readonly string _line = line.ParseDigits();

    private int FirstDigit()
    {
        return _line.GetFirstCharacter().ToInt();
    }

    private int LastDigit()
    {
        return _line.GetLastCharacter().ToInt();
    }

    public int ConcatenatedFirstAndLastDigit()
    {
        var firstAndLastDigits = $"{FirstDigit()}{LastDigit()}";
        return firstAndLastDigits.ToInt();
    }
}