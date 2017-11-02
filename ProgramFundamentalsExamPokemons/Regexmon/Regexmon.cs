using System;
using System.Text.RegularExpressions;

class Regexmon
{
    static void Main()
    {
        string text = Console.ReadLine();

        Regex didiRegex = new Regex(@"[^a-zA-Z-]+");

        Regex bojoRegex = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");

        while (true)
        {
            Match didiMatch = didiRegex.Match(text);

            if (didiMatch.Success)
            {
                Console.WriteLine(didiMatch.Value);

                text = RemoveBefore(didiMatch.Value.ToString(), text);
            }
            else
            {
                break;
            }

            Match bojoMatch = bojoRegex.Match(text);

            if (bojoMatch.Success)
            {
                Console.WriteLine(bojoMatch.Value);

                text = RemoveBefore(bojoMatch.Value.ToString(), text);
            }
            else
            {
                break;
            }
        }
    }

    private static string RemoveBefore(string match, string text)
    {
        int end = text.IndexOf(match) + match.Length;

        text = text.Substring(end, text.Length - end);

        return text;
    }
}
