using AdventOfCode2023.Utilities;
using System;

namespace AdventOfCode2023.Day01;

public class CalibrationDocumentProcessor(string path)
{
    private readonly List<string> _calibrationDocument = FileReader.ExtractInput(path, Environment.NewLine);

    public int CalculateTotalCalibrationValue()
    {
        int total = 0;

        foreach (var calibrationNumber in _calibrationDocument)
        {
            string numbers = string.Concat(calibrationNumber.Where(char.IsDigit));

            string firstDigit = numbers.Substring(0, 1);
            string lastDigit = numbers.Substring(numbers.Length - 1);
 
            string finalNumbers = firstDigit + lastDigit;

            int parsedNumbers = int.Parse(finalNumbers);

            total = total + parsedNumbers;

        }

        return total;
    }
}