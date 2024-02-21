using AdventOfCode2023.Utilities;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentProcessor(string path)
{
    private readonly List<string> _calibrationDocument = FileReader.ExtractInput(path, Environment.NewLine);

    public int CalculateTotalIntegerOnlyCalibrationValue()
    {
        var calibrationDocumentLines = _calibrationDocument.Select(line => new CalibrationDocumentLine(line));
        return calibrationDocumentLines.Sum(line => line.ConcatenatedFirstAndLastDigit());
    }

    public int CalculateTotalCalibrationValue()
    {
        // one, two, three, four, five, six, seven, eight, and nine also count as valid "digits".
        // "also" meaning not just only these written out numbers should be parsed, but the integer values themselves still
        
        // implementation goes here
        return 0;
    }
}