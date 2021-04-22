using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_StatGrad_B1_0202
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_StatGrad_B1_0202(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if ((x != !y || y && !z || z && !w) == false)
                                Console.WriteLine($"{Convert.ToInt32(w)} {Convert.ToInt32(z)} {Convert.ToInt32(x)} {Convert.ToInt32(y)}");
        }

        internal static void Solution_6()
        {
            for (int i = 6; i < 1000; i++)
            {
                int s = i, n = 36;
                s = (s + 1) / 7;

                while (s < 2050)
                {
                    s *= 2;
                    n += 3;
                }
                
                if (n == 60)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_8()
        {
            string[] table = new[] { "0", "1", "2", "3", "4", "5", "6" };

            List<string> count = new List<string>();
            foreach (var item in table)
                foreach (var item1 in table)
                    foreach (var item2 in table)
                        foreach (var item3 in table)
                            foreach (var item4 in table)
                                count.Add($"{item}{item1}{item2}{item3}{item4}");

            Console.WriteLine(count.Where(item => item.Count(x => x == '0') > 0 && item.Count(x => x == '6') <= 1).Count());
        }

        internal static void Solution_12()
        {
            Parallel.For(1, 46, (i, state) =>
               Parallel.For(1, 6, j =>
                  Parallel.For(1, 11, k =>
                  {
                       string s = "0" + String.Join("", Enumerable.Repeat("1", i)) + String.Join("", Enumerable.Repeat("2", j)) + String.Join("", Enumerable.Repeat("3", k));

                       while (s.Contains("01") || s.Contains("02") || s.Contains("03"))
                       {
                           s = new Regex("01").Replace(s, "30", 1);
                           s = new Regex("02").Replace(s, "101", 1);
                           s = new Regex("03").Replace(s, "202", 1);
                       }

                       if ((s.Count(x => x == '1') == 15) &&
                          (s.Count(x => x == '2') == 10) &&
                          (s.Count(x => x == '3') == 60))
                       {
                            Console.WriteLine(i);
                            state.Break();
                       }
                  })));
        }

        internal static void Solution_14()
        {
            for (int x = 1; x < 1000; x++)
            {
                BigInteger a = BigInteger.Pow(343, 5) + BigInteger.Pow(7, 3) - 1 - x;

                int count = 0;
                while (a != 0)
                {
                    if (a % 7 == 6)
                        count++;

                    a /= 7;
                }

                if (count == 12)
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }

        internal static void Solution_15()
        {
            for (int a = 1000; a > 1; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((70 % a == 0 && (x % 28 != 0 || x % a == 0 || x % 21 != 0)) == false)
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
                if (n == 0)
                    return 0;

                if (n % 2 == 0)
                    return F(n / 2);

                return 1 + F(n - 1);
            }

            for (int n = 1; n < 10000; n++)
            {
                if (F(n) == 12)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
        }

        internal static void Solution_17()
        {
            int count = 0, min = 50001;
            for (int i = 10001; i <= 50000; i++)
            {
                int d = 1, countdivs = 0;

                while (d * d < i)
                {
                    if (i % d == 0)
                        countdivs += 2;

                    d++;
                }

                if (d * d == i)
                    count++;

                if (countdivs >= 17)
                {
                    count++;

                    min = Math.Min(min, i);
                }
            }

            Console.WriteLine($"{count} {min}");
        }

        internal static void Solution_22()
        {
            for (int i = 1; i < 10000; i++)
            {
                int x = i, m = 0, s = 0, d;
                while (x > 0)
                {
                    d = x % 8;
                    s += d;
                    if (d > m)
                        m = d;
                    x /= 8;
                }

                if (m == 5 && s == 12)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 02.02.2021\24\24.txt");

            Dictionary<char, int> counter = s.Distinct().ToDictionary(x => x, x => 0);

            for (int i = 0; i < s.Length - 2; i++)
                if (s[i] == s[i + 2])
                    counter[s[i + 1]]++;

            Console.WriteLine(counter.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
        }

        internal static void Solution_25()
        {
            Parallel.For(101000000, 102000000, i =>
            {
                int d = 1, count = 0;

                while (d * d < i)
                {
                    if (i % d == 0)
                    {
                        if (d % 2 == 0)
                            count++;
                
                        if ((i / d) % 2 == 0)
                            count++;
                    }
                
                    d++;
                }
                
                if (d * d == i && d % 2 == 0)
                    count++;
                
                if (count == 3)
                    Console.WriteLine(i);
            });
        }
    }
}
