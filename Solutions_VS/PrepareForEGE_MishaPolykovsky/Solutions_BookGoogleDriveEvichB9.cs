using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_BookGoogleDriveEvichB9
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_BookGoogleDriveEvichB9(), use, startupOptions);

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 9\24\24.txt");

            #region Solve for Regex
            Console.WriteLine(Regex.Matches(s, @"([!|?|%])\1*").Select(m => m.Value.Length).Max());
            #endregion

            #region Solve standart
            int count = 1, max = 0;
            for (int i = 0; i < s.Length - 1; i++)
                if (s[i] == s[i + 1])
                {
                    count++;
                    max = Math.Max(max, count);
                }
                else
                {
                    max = Math.Max(max, count);
                    count = 1;
                }

            Console.WriteLine(max);
            #endregion
        }

        internal static void Solution_25()
        {
            for (int i = 51120; i <= 89080; i++)
            {
                int d = 2;
                List<int> count = new List<int>();

                while (d * d < i)
                {
                    if (i % d == 0 &&
                        i / d % 2 == 0 && i / d % 3 == 0 && i / d % 5 == 0)
                        count.AddRange(new List<int>() { i / d });

                    if (i % d == 0 &&
                        d % 2 == 0 && d % 3 == 0 && d % 5 == 0 && d != 3 && d != 5 && d != 2)
                        count.AddRange(new List<int>() { d });

                    d++;
                }

                if (d * d == i)
                    count.Add(d);

                count.OrderBy(x => x);
                if (count.Count == 2)
                    Console.WriteLine($"{i} {String.Join(" ", count)}");
            }
        }
    }
}
