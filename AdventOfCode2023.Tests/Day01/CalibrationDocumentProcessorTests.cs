using AdventOfCode2023.Day01;

namespace AdventOfCode2023.Tests.Day01;

[TestFixture]
public class CalibrationDocumentProcessorTests
{
    private CalibrationDocumentProcessor _calibrationDocumentProcessor = null!;
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _calibrationDocumentProcessor = new CalibrationDocumentProcessor("Day01/Resources/TestInput.txt");
    }
    
    [Test]
    public void CalculateTotalCalibrationValue()
    {
        var result = _calibrationDocumentProcessor.CalculateTotalCalibrationValue();
        Assert.That(result, Is.EqualTo(142));
    }
}