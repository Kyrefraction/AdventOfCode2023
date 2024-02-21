namespace AdventOfCode2023.Utilities.Extensions;

public static class StringExtensions
{
    public static string ParseDigits(this string value)
    {
        return string.Concat(value.Where(char.IsDigit));
    }

    public static int ToInt(this string value)
    {
        return int.Parse(value);
    }
}