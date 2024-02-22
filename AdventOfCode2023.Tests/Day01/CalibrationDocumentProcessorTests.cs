using AdventOfCode2023.Day01;
using AdventOfCode2023.Utilities;
using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Tests.Day01;

[TestFixture]
public class CalibrationDocumentProcessorTests
{
    private const string TestInput = "Day01/Resources/Inputs/TestPartOne.txt";
    private const string TestInputPartTwo = "Day01/Resources/Inputs/TestPartTwo.txt";
    private const string LiveInput = "Day01/Resources/Inputs/Live.txt";
    private const string TestInputAnswer = "Day01/Resources/Answers/TestPartOne.txt";
    private const string TestInputAnswerPartTwo = "Day01/Resources/Answers/TestPartTwo.txt";
    private const string LiveInputPartOneAnswer = "Day01/Resources/Answers/PartOne.txt";
    private const string LiveInputPartTwoAnswer = "Day01/Resources/Answers/PartTwo.txt";
    
    [TestCase(TestInput, TestInputAnswer)]
    [TestCase(LiveInput, LiveInputPartOneAnswer)]
    public void CalculateTotalIntegerOnlyCalibrationValue(string resourcePath, string answerPath)
    {
        var calibrationDocumentProcessor = new CalibrationDocumentProcessor(resourcePath);
        var result = calibrationDocumentProcessor.CalculateTotalIntegerOnlyCalibrationValue();
        Assert.That(result, Is.EqualTo(FileReader.ExtractInput(answerPath).ToInt()));
    }
    
    [TestCase(TestInputPartTwo, TestInputAnswerPartTwo)]
    [TestCase(LiveInput, LiveInputPartTwoAnswer)]
    public void CalculateTotalCalibrationValue(string resourcePath, string answerPath)
    {
        var calibrationDocumentProcessor = new CalibrationDocumentProcessor(resourcePath);
        var result = calibrationDocumentProcessor.CalculateTotalCalibrationValue();
        Assert.That(result, Is.EqualTo(FileReader.ExtractInput(answerPath).ToInt()));
    }
}