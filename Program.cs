using System;
using System.Text.RegularExpressions;

namespace LabWork
{
    class Program
    {
        static void Main()
        {
            // Текст для пошуку
            string text = "Текст з емодзі: 😊, ☀, ©, #, і деякі інші символи. 🌍";

            // Шаблон для пошуку емодзі та спеціальних символів
            string pattern = @"[\p{So}\p{Cn}]";

            // Пошук всіх відповідностей
            MatchCollection matches = Regex.Matches(text, pattern);

            // Виведення знайдених емодзі та спеціальних символів
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
