using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_BookGoogleDriveEvichB3
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_BookGoogleDriveEvichB3(), use, startupOptions);

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 3\Задание 24\24.txt");

            int counterA = 0, counter = 0;
            for (int i = 0; i < s.Length - 2; i++)
                if (s[i] != s[i + 1] && s[i] != s[i + 2] && s[i + 1] != s[i + 2])
                    if (s[i..(i + 3)].Contains("a"))
                        counterA++;
                    else
                        counter++;

            Console.WriteLine(Math.Abs(counter - counterA));
        }

        internal static void Solution_25()
        {
            for (int i = 105000; i < 135200; i++)
            {
                for (int b = 2; b < Math.Pow(i, 0.4); b++)
                {
                    for (int n = 3; n < i; n++)
                    {
                        if (Math.Pow(b, n) == i)
                            Console.WriteLine($"{i} {b} {n}");

                        if (Math.Pow(b, n) > i)
                            break;
                    }
                }
            }
        }
    }
}