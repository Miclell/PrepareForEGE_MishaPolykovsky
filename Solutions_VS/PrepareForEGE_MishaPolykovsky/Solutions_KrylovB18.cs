using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_KrylovB18
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_KrylovB18(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if ((!x || y || (z && !w)) == false)
                                Console.WriteLine($"{Convert.ToInt32(x)} {Convert.ToInt32(z)} {Convert.ToInt32(w)} {Convert.ToInt32(y)}");
        }

        internal static void Solution_6()
        {
            for (int i = 1000; i > 1; i--)
            {
                int s = i, n = 80;

                while (s <= 75)
                {
                    s += 4;
                    n -= 4;
                }

                if (n == 4)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_8()
        {
            string[] table = new[] { "К", "О", "С", "У", "Ф" };

            List<string> newTable = new();
            foreach (var item in table)
                foreach (var item1 in table)
                    foreach (var item2 in table)
                        foreach (var item3 in table)
                            foreach (var item4 in table)
                                newTable.Add($"{item}{item1}{item2}{item3}{item4}");

            Console.WriteLine(newTable.IndexOf("ФОКУС") + 1);
        }

        internal static void Solution_12()
        {
            string s = String.Join("", Enumerable.Repeat("5", 151));

            while (s.Contains("88") || s.Contains("555"))
            {
                if (s.Contains("555"))
                    s = new Regex("555").Replace(s, "8", 1);
                else
                    s = new Regex("88").Replace(s, "5", 1);
            }

            Console.WriteLine(s);
        }

        internal static void Solution_15()
        {
            for (int a = 0; a < 1000; a++)
            {
                bool flag = true;

                for (int x = 0; x < 10000; x++)
                    if (((x & 12) == 0 || (x & 24) != 0 || (x & a) != 0) == false)
                        flag = false;

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
                if (n == 1)
                    return 2;

                if (n % 2 == 0)
                    return n + 2 + F(n - 1);

                return F(2) * F(n - 2);
            }

            Console.WriteLine(F(14));
        }

        internal static void Solution_17()
        {
            int count = 0, sum = 0;
            for (int i = 1244; i <= 2122; i++)
                if (i % 10 == i / 10 % 10 || i % 3 != 0 && i % 4 != 0)
                {
                    count++;
                    sum += i;
                }

            Console.WriteLine($"{count} {sum}");
        }

        internal static void Solution_22()
        {
            for (int i = 99999; i > 1; i -= 2)
            {
                int L = 22, D = i, M = 87;

                while (L <= M)
                {
                    L += 2 * D;
                    M += D;
                }

                if (L == 162)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_23()
        {
            static int F(int n)
            {
                if (n == 3)
                    return 1;

                if (n % 3 == 0 && n - 3 >= 3 && n / 3 >= 3)
                    return F(n - 3) + F(n / 3);

                if (n - 3 >= 3)
                    return F(n - 3);

                return 0;
            }

            static int G(int n)
            {
                if (n == 27)
                    return 1;

                if (n == 78)
                    return 0;

                if (n % 3 == 0 && n - 3 >= 27 && n / 3 >= 27)
                    return G(n - 3) + G(n / 3);

                if (n - 3 >= 27)
                    return G(n - 3);

                return 0;
            }

            Console.WriteLine(F(27) * G(108));
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Крылов\Informatika-2021-20\24\24 варианты 17-20.txt");

            Console.WriteLine(Regex.Matches(s, @"[ABC]*").Select(x => x.Value.Length).Max());
        }

        internal static void Solution_25()
        {
            static bool IsPrime(int n)
            {
                if (n <= 1)
                    return false;

                int d = 2;
                while (d * d <= n)
                {
                    if (n % d == 0)
                        return false;
                    d++;
                }

                return true;
            }

            int count = 0;
            for (int i = 750000; count != 5; i++)
            {
                int d = 2, s = 0;
                while (d * d < i)
                {
                    if (i % d == 0)
                    {
                        if (IsPrime(d))
                            s += d;
                        if (IsPrime(i / d))
                            s += i / d;
                    }
                    d++;
                }

                if (d * d == i && IsPrime(d))
                    s += d;

                if (s != 0 && s % 15 == 0)
                {
                    Console.WriteLine($"{i} {s}");
                    count++;
                }
            }
        }

        internal static void Solution_27()
        {
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Крылов\Informatika-2021-20\27\27v18_B.txt");

            int[][] sn = s.Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value)).ToArray()).ToArray();

            int sum = 0, min = int.MaxValue;
            for (int i = 1; i < sn.Length; i++)
            {
                sum += Math.Min(sn[i][0], sn[i][1]);

                int dif = Math.Abs(sn[i][0] - sn[i][1]);
                min = Math.Min(dif % 65 != 0 ? dif : int.MaxValue, min);
            }

            if (sum % 65 != 0)
                Console.WriteLine(sum);
            else
                Console.WriteLine(sum + min);
        }
    }
}
