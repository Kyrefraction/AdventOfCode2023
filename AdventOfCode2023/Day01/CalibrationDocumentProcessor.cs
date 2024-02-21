using AdventOfCode2023.Utilities;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentProcessor(string path)
{
    private readonly List<string> _calibrationDocument = FileReader.ExtractInput(path, Environment.NewLine);

    public int CalculateTotalCalibrationValue()
    {
        var calibrationDocumentLines = _calibrationDocument.Select(line => new CalibrationDocumentLine(line));
        return calibrationDocumentLines.Sum(line => line.ConcatenatedFirstAndLastDigit());
    }
}