using System;
using System.Text.RegularExpressions;
					
public class Program
{	
	private static Regex IllegalFilenameCharactersRegex = new Regex(@"[\\/:*?""<>|]");
	
	public static void Main()
	{	
		Console.WriteLine(RemoveIllegalFilenameCharacters("Hello ::|>W\\///?orl?::d"));
	}
	
	private static string RemoveIllegalFilenameCharacters(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            return fileName;
        }

        return IllegalFilenameCharactersRegex.Replace(fileName, "");
    }
}