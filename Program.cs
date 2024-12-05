using System;
using System.Text.RegularExpressions;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть текст:");
            string inputText = Console.ReadLine();

            const string phonePattern = @"\+3\(\d{3}\)-\d{3}-\d{4}";

            MatchCollection matches = Regex.Matches(inputText, phonePattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Знайдені номери телефонів:");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Номери телефонів не знайдено.");
            }
        }
    }
}
