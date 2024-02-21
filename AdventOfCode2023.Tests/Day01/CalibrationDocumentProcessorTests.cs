using AdventOfCode2023.Day01;
using AdventOfCode2023.Utilities;
using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Tests.Day01;

[TestFixture]
public class CalibrationDocumentProcessorTests
{
    private const string TestInput = "Day01/Resources/TestInput.txt";
    private const string LiveInput = "Day01/Resources/Input.txt";
    private const string TestInputAnswer = "Day01/Resources/TestInputAnswer.txt";
    private const string LiveInputPartOneAnswer = "Day01/Resources/PartOneAnswer.txt";
    
    [TestCase(TestInput, TestInputAnswer)]
    [TestCase(LiveInput, LiveInputPartOneAnswer)]
    public void CalculateTotalCalibrationValue(string resourcePath, string answerPath)
    {
        var calibrationDocumentProcessor = new CalibrationDocumentProcessor(resourcePath);
        var result = calibrationDocumentProcessor.CalculateTotalCalibrationValue();
        Assert.That(result, Is.EqualTo(FileReader.ExtractInput(answerPath).ToInt()));
    }
}