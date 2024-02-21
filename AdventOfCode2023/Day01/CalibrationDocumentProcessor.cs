using AdventOfCode2023.Utilities;
using System;
using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentProcessor(string path)
{
    private readonly List<string> _calibrationDocument = FileReader.ExtractInput(path, Environment.NewLine);

    public int CalculateTotalCalibrationValue()
    {
        var total = 0;

        foreach (var calibrationDocumentLine in _calibrationDocument)
        {
            var numbers = calibrationDocumentLine.ParseDigits();
            
            var firstDigit = numbers.Substring(0, 1);
            var lastDigit = numbers.Substring(numbers.Length - 1, 1);
            
            var finalNumbers = $"{firstDigit}{lastDigit}";
            var parsedNumbers = finalNumbers.ToInt();

            total += parsedNumbers;
        }

        return total;
    }
}