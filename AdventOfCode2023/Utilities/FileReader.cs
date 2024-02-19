namespace AdventOfCode2023.Utilities;

public static class FileReader
{
    public static string ExtractInput(string path)
    {
        return File.ReadAllText(path);
    }

    public static List<string> ExtractInput(string path, string splitValue)
    {
        return ExtractInput(path).Split(splitValue).ToList();
    }
}