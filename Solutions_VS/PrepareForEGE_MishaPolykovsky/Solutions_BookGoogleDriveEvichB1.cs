using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_BookGoogleDriveEvichB1
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_BookGoogleDriveEvichB1(), use, startupOptions);

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 1\Задание 24\24.txt");

            Console.WriteLine(Regex.Matches(s, @"(\w)*").Select(x => x.Value.Length).Max());
        }

        internal static void Solution_25()
        {
            for (int i = 153222; i <= 153270; i++)
            {
                int count = 0;
                Tuple<int, int> numbs = new Tuple<int, int>(0, 0);
                for (int b = 1; b < 10000; b++)
                {
                    for (int a = 1; a <= b; a++)
                    {
                        if (a * a + b * b == i)
                        {
                            numbs = new Tuple<int, int>(a, b);
                            count++;
                        }

                        if (count > 1)
                            goto Check;
                    }
                }

                if (count == 1)
                    Console.WriteLine($"{numbs.Item1} {numbs.Item2}");

            Check:;
            }
        }
    }
}
