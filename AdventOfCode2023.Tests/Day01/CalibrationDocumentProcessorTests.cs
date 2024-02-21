using AdventOfCode2023.Day01;
using AdventOfCode2023.Utilities;
using AdventOfCode2023.Utilities.Extensions;

namespace AdventOfCode2023.Tests.Day01;

[TestFixture]
public class CalibrationDocumentProcessorTests
{
    private const string TestInput = "Day01/Resources/TestInput.txt";
    private const string LiveInput = "Day01/Resources/Input.txt";
    
    private CalibrationDocumentProcessor _calibrationDocumentProcessor = null!;
    private readonly int _partOneAnswer = FileReader.ExtractInput("Day01/Resources/PartOneAnswer.txt").ToInt();
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _calibrationDocumentProcessor = new CalibrationDocumentProcessor(LiveInput);
    }
    
    [Test]
    public void CalculateTotalCalibrationValue()
    {
        var result = _calibrationDocumentProcessor.CalculateTotalCalibrationValue();
        Assert.That(result, Is.EqualTo(_partOneAnswer));
    }
}