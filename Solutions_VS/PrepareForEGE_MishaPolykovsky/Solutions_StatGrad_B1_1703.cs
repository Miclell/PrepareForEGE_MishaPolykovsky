using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_StatGrad_B1_1703
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_StatGrad_B1_1703(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            List<string> lst = new();
            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if (!((!x && !y) || (z && w)) && (!x || w))
                                lst.Add($"{Convert.ToInt32(z)} {Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(w)}");
                                //Console.WriteLine($"{Convert.ToInt32(z)} {Convert.ToInt32(w)} {Convert.ToInt32(y)} {Convert.ToInt32(x)}");

            //Console.WriteLine(string.Join("\n", lst));
            Console.WriteLine($"{lst[4]}\n{lst[2]}\n{lst[1]}");
        }

        internal static void Solution_5()
        {
            for (int i = 100; i < 10000; i++)
            {
                string dtemp = Convert.ToString(i, 2);

                for (int j = 0; j < 3; j++)
                    if (dtemp.Count(x => x == '0') == dtemp.Count(x => x == '1'))
                        dtemp += dtemp[^1];
                    else if (dtemp.Count(x => x == '0') > dtemp.Count(x => x == '1'))
                        dtemp += "1";
                    else
                        dtemp += "0";

                if (Convert.ToInt32(dtemp, 2) % 4 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_6()
        {
            for (int i = 1; i < 2022; i++)
            {
                int s = 10 * i + 5, n = 1;
                while (s < 2021)
                {
                    s += 2 * n;
                    n++;
                }

                if (n == 11)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_8()
        {
            string[] table = new[] { "А", "В", "Е", "И", "К", "Н", "О", "Р" };

            List<string> lst = new();
            lst.AddRange(from item in table
                         from item1 in table
                         from item2 in table
                         select $"{item}{item1}{item2}");

            lst = lst.Where(x => x.Count(x => x == 'В') == 1).ToList();

            Console.WriteLine(lst.IndexOf("ВЕЕ") + 1);
        }

        internal static void Solution_12()
        {
            Parallel.For(1, 50, (x, state) =>
            {
                Parallel.For(1, 45, y =>
                {
                    Parallel.For(1, 40, z =>
                    {
                        string s = "0" + String.Join("", Enumerable.Repeat("1", x)) + String.Join("", Enumerable.Repeat("2", y)) + String.Join("", Enumerable.Repeat("3", z));

                        while (s.Contains("01") || s.Contains("02") || s.Contains("03"))
                        {
                            s = new Regex("01").Replace(s, "2302", 1);
                            s = new Regex("02").Replace(s, "10", 1);
                            s = new Regex("03").Replace(s, "201", 1);
                        }

                        if (s.Count(x => x == '1') == 40 &&
                            s.Count(x => x == '2') == 10 &&
                            s.Count(x => x == '3') == 8)
                        {
                            Console.WriteLine(x);
                            state.Stop();
                        }
                    });
                });
            });
        }

        internal static void Solution_14()
        {
            BigInteger a = BigInteger.Pow(729, 7) + BigInteger.Pow(3, 16) - 18;

            int count = 0;
            while (a != 0)
            {
                if (a % 9 == 0)
                    count++;

                a /= 9;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            for (int a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((a % 45 == 0 && (750 % x != 0 || a % x == 0 || 120 % x != 0)) == false)
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

                if (n % 3 == 0)
                    return F(n / 3);

                return n % 3 + F(n - n % 3);
            }

            for (int i = 0; i < 1000; i++)
            {
                if (F(i) == 11)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_17()
        {
            static bool IsPrime(int n)
            {
                if (n <= 1)
                    return false;

                for (int d = 2; d * d <= n; d++)
                    if (n % d == 0)
                        return false;

                return true;
            }

            int counter = 0, min = 50001;
            for (int i = 10001; i <= 50000; i++)
            {
                int count = 0, d;
                for (d = 1; d * d < i; d++)
                    if (i % d == 0)
                    {
                        if (IsPrime(d))
                            count++;

                        if (IsPrime(i / d))
                            count++;
                    }

                if (d * d == i && IsPrime(d))
                    count++;

                if (count == 3)
                {
                    counter++;
                    min = Math.Min(i, min);
                }
            }

            Console.WriteLine($"{counter} {min}");
        }

        internal static void Solution_22()
        {
            for (int i = 1; i < 10000; i++)
            {
                int x = i, k = i % 9, a = 0, b = 0, d;
                while (x > 0)
                {
                    d = x % 9;
                    if (d == k) 
                        a++;

                    b += d;
                    x /= 9;
                }

                if (a == 3 && b == 10)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_23()
        {
            static int F(int start, int end)
            {
                List<int> res = Enumerable.Repeat(0, end + 1).ToList();
                res[start] = 1;

                for (int i = start; i <= end; i++)
                {
                    if (i != 30)
                    {
                        if (i + 1 <= end)
                            res[i + 1] += res[i];
                        if (i * 2 <= end)
                            res[i * 2] += res[i];
                        if (i * 3 <= end)
                            res[i * 3] += res[i];
                    }
                    else
                        res[i] = 0;
                }

                return res[end];
            }
            
            Console.WriteLine(F(2, 12) * F(12, 36));
        }

        internal static void Solution_24()
        {
            static char Check(string s)
            {
                Dictionary<char, int> counter = s.ToArray().Distinct().OrderBy(x => x).ToDictionary(x => x, x => 0);

                foreach (var item in s)
                    counter[item]++;

                return counter.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            }

            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 17.03.2021\24\24.txt");

            int min = Int32.MaxValue;
            char let = ' ';

            //s = new[] { "GIGA", "GABLAB", "AGAAA" };

            foreach (var line in s)
            {
                int counterG = line.Count(x => x == 'G');
                if (counterG < min)
                {
                    min = counterG;
                    let = Check(line);
                }
            }

            Console.WriteLine($"{let}");
        }

        internal static void Solution_25()
        {
            Parallel.For(35000000, 40000000, i =>
            {
                int count = 0, d;
                for (d = 1; d * d < i; d++)
                    if (i % d == 0)
                    {
                        if (d % 2 != 0)
                            count++;
            
                        if (i / d % 2 != 0)
                            count++;
                    }
            
                if (d * d == i && d % 2 != 0)
                    count++;
            
                if (count == 5)
                    Console.WriteLine(i);
            });          
        }

        internal static void Solution_26()
        {
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 17.03.2021\26\26.txt");

            List<int> sInt = s.Skip(1).Select(x => int.Parse(x)).OrderBy(x => x).ToList();

            int count = 0, max = 0;
            Parallel.For(0, sInt.Count, i =>
            {
                Parallel.For (i + 1, sInt.Count, j =>
                {
                    if (sInt[i] % 2 == 0 &&
                        sInt[j] % 2 == 0 &&
                        sInt.BinarySearch((sInt[i] + sInt[j]) / 2) >= 0)
                    {
                        count++;

                        max = Math.Max((sInt[i] + sInt[j]) / 2, max);
                    }
                });
            });

            Console.WriteLine($"{count} {max}");
        }

        internal static void Solution_27()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 17.03.2021\27\27-A.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 17.03.2021\27\27-B.txt");
            //string[] s = new[] { "4", "5", "8", "14", "11" };

            List<int> sInt = s.Skip(1).Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();

            int count = 30, max = 0;
            Parallel.For(0, count, i =>
            {
                Parallel.For(i + 1, count, j =>
                {
                    Parallel.For(j + 1, count, f =>
                    {
                        if ((sInt[i] + sInt[j] + sInt[f]) % 3 == 0)
                            max = Math.Max(sInt[i] + sInt[j] + sInt[f], max);
                    });
                });
            });

            Console.WriteLine(max);
        }
    }
}
