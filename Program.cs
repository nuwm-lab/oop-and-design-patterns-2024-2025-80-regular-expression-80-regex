using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст:");
        string input = Console.ReadLine();

        string result = OOk(input);

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }

    static string OOk(string input)
    {
        Regex regex = new Regex("[оo]", RegexOptions.IgnoreCase);
        MatchCollection matches = regex.Matches(input);
        int offset = 0;

        foreach (Match match in matches)
        {
            int index = match.Index + offset;
            input = input.Substring(0, index) + match.Value + "ОК" + input.Substring(index + match.Length);
            offset += 2;
        }

        return input;
    }
}
