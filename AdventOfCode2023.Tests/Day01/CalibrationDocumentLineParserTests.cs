using AdventOfCode2023.Day01;

namespace AdventOfCode2023.Tests.Day01;

[TestFixture]
public class CalibrationDocumentLineParserTests
{
    [TestCase("xtwone3four", "2134")]
    [TestCase("4nineeightseven2", "49872")]
    [TestCase("zoneight234", "18234")]
    [TestCase("7pqrstsixteen", "76")]
    public void Parse(string input, string expectedResult)
    {
        var result = CalibrationDocumentLineParser.Parse(input);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}