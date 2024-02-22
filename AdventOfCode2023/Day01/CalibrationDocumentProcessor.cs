using AdventOfCode2023.Utilities;
using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentProcessor(string path)
{
    private readonly List<string> _calibrationDocument = FileReader.ExtractInput(path, Environment.NewLine);

    public int CalculateTotalIntegerOnlyCalibrationValue()
    {
        return _calibrationDocument
            .Select(line => line.ParseDigits())
            .Sum(line => $"{line.GetFirstCharacter()}{line.GetLastCharacter()}".ToInt());
    }

    public int CalculateTotalCalibrationValue()
    {
        return _calibrationDocument.Select(CalibrationDocumentLineParser.Parse)
            .Select(parsedLine => $"{parsedLine.GetFirstCharacter()}{parsedLine.GetLastCharacter()}".ToInt())
            .Sum();
    }
}