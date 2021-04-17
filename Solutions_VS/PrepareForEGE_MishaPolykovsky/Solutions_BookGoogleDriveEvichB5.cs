using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_BookGoogleDriveEvichB5
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_BookGoogleDriveEvichB5(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if ((x != y) && (!y || !z) && (z || w))
                                Console.WriteLine($"{Convert.ToInt32(w)} {Convert.ToInt32(x)} {Convert.ToInt32(z)} {Convert.ToInt32(y)}");
        }

        internal static void Solution_6()
        {
            for (int i = 1; i < 10000; i++)
            {
                int n = i, s = 1;

                while (n <= 210)
                {
                    s *= 3;
                    n += 30;
                }

                if (s == 729)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_12()
        {
            string s = String.Join("", Enumerable.Repeat("7", 112));

            while (s.Contains("111") || s.Contains("7777"))
            {
                if (s.Contains("111"))
                    s = new Regex("111").Replace(s, "7", 1);
                else
                    s = new Regex("7777").Replace(s, "1", 1);
            }

            Console.WriteLine(s);
        }

        internal static void Solution_14()
        {
            BigInteger a = BigInteger.Pow(9, 1700) + BigInteger.Pow(3, 1800) - BigInteger.Pow(3, 350) + 2;

            int count = 0;
            while (a != 0)
            {
                if (a % 3 == 2)
                    count++;

                a /= 3;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            for (int a = 0; a < 10000; a++)
            {
                bool flag = true;

                for (int x = 0; x < 1000; x++)
                {
                    if (((BigInteger.GreatestCommonDivisor(x, 360) != 1 || BigInteger.GreatestCommonDivisor(a, x) == 1) &&
                    (BigInteger.GreatestCommonDivisor(x, a) != 1 || BigInteger.GreatestCommonDivisor(x, 240) == 1)) == false)
                        flag = false;
                }

                if (flag)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }

        internal static void Solution_16()
        {
            static int F(int n)
            {
                if (n < 20)
                    return 2;

                if (n < 150)
                    return 1 + 2 * F(n - 17);

                if (n < 1000)
                    return -3 + F(n - 23);

                return 2 + F(n - 42);
            }

            Console.WriteLine(F(1150));
        }

        internal static void Solution_17()
        {
            int min = 9999, max = 0, count = 0;
            for (int i = 5835; i < 9762; i++)
            {
                if (i % 7 == 2 && i % 3 == 1 &&
                (i % 8 == 5 || i % 11 == 5))
                {
                    count++;

                    max = Math.Max(i, max);

                    min = Math.Min(i, min);
                }
            }

            Console.WriteLine($"{count} {max - min}");
        }

        internal static void Solution_22()
        {
            int x, K, R, y;

            for (int i = 0; i < 100000; i++)
            {
                x = i;

                K = 0;
                R = 9;
                y = x % 10;

                while (x > 0)
                {
                    K++;

                    if (R > x % 10)
                        R = x % 10;

                    x /= 10;
                }

                R = y - R;

                if (K == 4 && R == 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 5\Задание 24\24.txt");

            int count = 1, max = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
                else
                {
                    if (i - count >= 0 && s[i + 1] == s[i - count])
                        max = Math.Max(max, count);

                    count = 1;
                }
            }

            Console.WriteLine(max);
        }

        internal static void Solution_25()
        {
            for (int i = 3954; i <= 8979; i++)
            {
                int d = 1, count = 0;
                while (d * d < i)
                {
                    if (i % d == 0)
                        count += 2;

                    d++;
                }

                if (d * d == i)
                    count++;

                if (count >= 41 && count <= 45)
                    Console.WriteLine($"{i} {count}");
            }
        }

        internal static void Solution_27()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 5\Задание 27\27.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 5\Задание 27\27-a.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Решения из книги Евич\Вариант 5\Задание 27\27-b.txt");

            Dictionary<int, List<int>> dict = Enumerable.Range(1, 5000).ToDictionary(x => x, x => new List<int>());
            for (int i = 1; i < s.Length; i++)
            {
                List<int> temp = Regex.Matches(s[i], @"[0-9]+").Select(x => int.Parse(x.Value)).ToList();

                dict[temp[0]].Add(Math.Max(temp[1], Math.Max(temp[2], temp[3])));
            }

            int d = Regex.Matches(s.First().ToString(), @"[0-9]+").Select(x => int.Parse(x.Value)).ToList()[1];

            List<float> averageResults = new List<float>();
            for (int i = 1; i <= 5000; i++)
                if (dict[i].Count > d)
                    averageResults.Add((float)dict[i].Sum() / dict[i].Count);

            Console.WriteLine(Math.Round(averageResults.Max() - averageResults.Min(), 2));
        }
    }
}
