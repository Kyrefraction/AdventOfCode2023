using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentLine(string line)
{
    private readonly string _line = line.ParseDigits();

    private int FirstDigit()
    {
        return _line[..1].ToInt();
    }

    private int LastDigit()
    {
        return _line.Substring(_line.Length - 1, 1).ToInt();
    }

    public int ConcatenatedFirstAndLastDigit()
    {
        var finalNumbers = $"{FirstDigit()}{LastDigit()}";
        return finalNumbers.ToInt();
    }
}