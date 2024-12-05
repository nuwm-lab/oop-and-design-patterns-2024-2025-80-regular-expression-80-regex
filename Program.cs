using System;
using System.Text;
using System.Text.RegularExpressions;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть текст: ");
            string inputText = Console.ReadLine();

            const string pattern = @"^[A-Za-z0-9\s.,!?'\-]+$";
            bool isEnglishText = Regex.IsMatch(inputText, pattern) && ContainsEnglishLettersOnly(inputText);

            if (isEnglishText)
            {
                Console.WriteLine("Текст є англійською мовою.");
            }
            else
            {
                Console.WriteLine("Текст не є англійською мовою.");
            }
        }

        private static bool ContainsEnglishLettersOnly(string text)
        {
            return Regex.IsMatch(text, @"[A-Za-z]");
        }
    }
}
