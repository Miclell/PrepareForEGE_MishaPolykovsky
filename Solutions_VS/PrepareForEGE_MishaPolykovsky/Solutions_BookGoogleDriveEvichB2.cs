using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_BookGoogleDriveEvichB2
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_BookGoogleDriveEvichB2(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            Console.WriteLine(String.Join("\n", (from x in table
                                                 from y in table
                                                 from z in table
                                                 from w in table
                                                 select (((x == w) || (y && !z) || w) == false) ?
                                                 $"{Convert.ToInt32(x)} {Convert.ToInt32(w)} {Convert.ToInt32(z)} {Convert.ToInt32(y)}"
                                                 : "").Distinct()));
        }

        internal static void Solution_6()
        {
            int x = 120, p = 12;

            while (p <= x + 15)
            {
                p += 10;
                x -= 5;
            }

            Console.WriteLine(x);
        }

        internal static void Solution_12()
        {
            string s = ">" + String.Join("", Enumerable.Repeat("1", 32).ToArray()) +
            String.Join("", Enumerable.Repeat("4", 11).ToArray()) +
            String.Join("", Enumerable.Repeat("6", 22).ToArray());

            while (s.Contains(">1") || s.Contains(">4") || s.Contains(">6"))
            {
                s = new Regex(">1").Replace(s, "1661>", 1);
                s = new Regex(">4").Replace(s, "146141>", 1);
                s = new Regex(">6").Replace(s, "141>", 1);
            }

            Console.WriteLine(s[..^1].Select(x => Convert.ToInt32(x.ToString())).Sum());
        }

        internal static void Solution_14()
        {
            BigInteger bi = BigInteger.Pow(256, 500) * BigInteger.Pow(4, 100) - BigInteger.Pow(64, 30) - 8;

            int count = 0;
            while (bi != 0)
            {
                if (bi % 4 == 3)
                    count++;

                bi /= 4;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            for (int a = 1000; a > 0; a--)
                if (396 % a == 0 && 180 % a == 0)
                {
                    Console.WriteLine(a);
                    break;
                }
        }

        internal static void Solution_16()
        {
            static int F(int n)
            {
                if (n == 1)
                    return 2;

                if (n % 2 == 0)
                    return n + F(n / 2);

                return 5 * F(n - 1);
            }

            Console.WriteLine(F(79));
        }

        internal static void Solution_17()
        {
            var a = Enumerable.Range(2247, 4236).Where(x => Regex.Matches(x.ToString(), @"[24680]{4}").Count() == 1);

            Console.WriteLine($"{a.Count()} {a.Sum()}");
        }

        internal static void Solution_22()
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = i, d = 0, a = 0;

                while (x > 0)
                {
                    d += x % 5;
                    a++;
                    x /= 5;
                }

                if (a == 4 && d == 12)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 2\Задание 24\24.txt");

            Console.WriteLine(Regex.Matches(s, @"\w+").Select(x => x.Value.Length).Min());
        }

        internal static void Solution_25()
        {
            for (int i = 164361; i <= 164423; i++)
            {
                List<Tuple<int, int>> counter = new List<Tuple<int, int>>();
                for (int b = 0; b < 1000; b++)
                    for (int a = 0; a <= b; a++)
                        if (a * a + b * b == i)
                            counter.Add(new Tuple<int, int>(a, b));

                if (counter.Count == 1)
                    Console.WriteLine($"{counter[0].Item1} {counter[0].Item2}");
            }
        }
    }
}
