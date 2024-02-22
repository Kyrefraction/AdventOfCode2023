namespace AdventOfCode2023.Utilities.Extensions;

public static class StringExtensions
{
    public static string SafeSubstring(this string value, int startIndex, int length)
    {
        return startIndex + length <= value.Length ? value.Substring(startIndex, length) : value[startIndex..];
    }
    
    public static string GetFirstCharacter(this string value)
    {
        return value[..1];
    }
    
    public static string GetLastCharacter(this string value)
    {
        return value.Substring(value.Length - 1, 1);
    }
    
    public static string ParseDigits(this string value)
    {
        return string.Concat(value.Where(char.IsDigit));
    }

    public static int ToInt(this string value)
    {
        return int.Parse(value);
    }
}