using System;
using System.Numerics;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_BookGoogleDriveB2
    {
        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if (((x && !y) || (x == z) || !w) == false)
                                Console.WriteLine($"{Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(w)} {Convert.ToInt32(x)}");
        }

        internal static void Solution_6()
        {
            for (int i = 1000; i > 0; i--)
            {
                int s = 155;
                int n = i;

                while (s - n > 0)
                {
                    s -= 5;
                    n += 10;
                }

                if (s == 145)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_8()
        {
            static bool Check(int n)
            {
                if ((n % 5 == 0) &&
                    (n.ToString()[0] != n.ToString()[1]) &&
                    (n.ToString()[0] != n.ToString()[2]) &&
                    (n.ToString()[0] != n.ToString()[3]) &&
                    (n.ToString()[1] != n.ToString()[2]) &&
                    (n.ToString()[1] != n.ToString()[3]) &&
                    (n.ToString()[2] != n.ToString()[3]) &&
                    ((n.ToString()[0] % 2 == 0) && (n.ToString()[1] % 2 != 0) ||
                    (n.ToString()[0] % 2 != 0) && (n.ToString()[1] % 2 == 0)) &&
                    ((n.ToString()[1] % 2 == 0) && (n.ToString()[2] % 2 != 0) ||
                    (n.ToString()[1] % 2 != 0) && (n.ToString()[2] % 2 == 0)) &&
                    ((n.ToString()[2] % 2 == 0) && (n.ToString()[3] % 2 != 0) ||
                    (n.ToString()[2] % 2 != 0) && (n.ToString()[3] % 2 == 0)))
                    return true;

                return false;
            } //можно было сделать через цикл

            int count = 0;
            for (int i = 1000; i < 10000; i++)
            {
                if (Check(i))
                    count++;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_12()
        {
            string s = "";

            for (int i = 0; i < 60; i++)
                s += "4";

            for (int i = 0; i < 60; i++)
                s += "6";

            for (int i = 0; i < 60; i++)
                s += "8";

            while ((s.IndexOf("46") != -1) || (s.IndexOf("84") != -1) || (s.IndexOf("86") != -1))
            {
                for (int i = 0; i < s.Length - 2; i++)
                {
                    if ((s[i] == '4') && (s[i + 1] == '6'))
                    {
                        s = s.Remove(i, 2);
                        s = s.Insert(i, "64");
                        i = 0;
                    }

                    if ((s[i] == '8') && (s[i + 1] == '4'))
                    {
                        s = s.Remove(i, 2);
                        s = s.Insert(i, "48");
                        i = 0;
                    }

                    if ((s[i] == '8') && (s[i + 1] == '6'))
                    {
                        s = s.Remove(i, 2);
                        s = s.Insert(i, "68");
                        i = 0;
                    }
                }
            }

            Console.WriteLine($"{s[25]} {s[75]} {s[150]}");
        }

        internal static void Solution_14()
        {
            BigInteger a = BigInteger.Pow(16, 8) * BigInteger.Pow(4, 20) - BigInteger.Pow(4, 10) - 4;

            int count = 0;
            while (a != 0)
            {
                if (a % 4 == 3)
                    count++;

                a /= 4;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    for (int y = 1; y < 1000; y++)
                    {
                        if (((y + 3 * x > a) || (x < 20) || (y < 20)) == false)
                            flag = false;
                    }
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_16()
        {
            static int F(int n)
            {
                if (n == 1)
                    return 1;

                if (n % 2 == 0)
                    return 3 * n + F(n - 1);

                return 3 * F(n - 2);
            }

            Console.WriteLine(F(20));
        }

        internal static void Solution_17()
        {
            int count = 0, max = 0;
            for (int i = 800; i <= 5900; i++)
                if ((i % 19 == 0) && (i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0))
                {
                    count++;

                    if (i > max)
                        max = i;
                }

            Console.WriteLine($"{count} {max}");
        }

        internal static void Solution_22()
        {
            int x, L, M;
            for (x = 1000; x > 0; x--)
            {
                L = 1; M = 0; int y = x;
                while (y > 0)
                {
                    M += 1;

                    if (y % 2 == 0)
                    {
                        L *= (y % 8);
                    }

                    y /= 8;
                }

                if ((L == 12) && (M == 3))
                    goto Finsih;
            }

        Finsih:
            Console.WriteLine(x);
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\24.txt");

            var m = new Regex(@"([\w])").Matches(s);
            var strm = new Match[m.Count];
            m.CopyTo(strm, 0);
            Console.WriteLine(strm.OrderBy(x => x.Length).Count());
        } // страшилка P.S. Сан Саныч, если вы знаете как это сделать в одну строчку при помощи страшных методов - то скажите пожалуйста)
                                              // я просто пытался сделать через регулярные выражения и LINQ, но посчиать то, что мне надо так и не получилось(

        internal static void Solution_24_Adekvat()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\24.txt");

            int max = 0, count = 0;
            char lastChar = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                    count++;
                else if (count > max) 
                {
                    lastChar = s[i];
                    max = count; 
                    count = 0; 
                }
            }

            if (count > max) 
                max = count;

            Console.WriteLine(max);
        }

        internal static void Solution_25()
        {
            for (int i = 550; i <= 600; i++)
            {
                bool flag = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        flag = false;
                }

                if (flag)
                    Console.WriteLine(i);
            }
        }

        internal static void Solution_27()
        {
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\zad27.txt");

            string[] maxPair = new[] { "0", "0", "0" };
            for (int i = 1; i < s.Length; i++)
            {
                for (int j = 1; j < s.Length; j++)
                {
                    if (((Convert.ToInt32(s[i]) % 25 == 0) || (Convert.ToInt32(s[j]) % 25 == 0)) && 
                        ((Convert.ToInt32(s[i]) - Convert.ToInt32(s[j])) % 2 == 0) && 
                        ((Convert.ToInt32(s[i]) + Convert.ToInt32(s[j])) > Convert.ToInt32(maxPair[2])))
                    {
                        maxPair[0] = s[i];
                        maxPair[1] = s[j];
                        maxPair[2] = (Convert.ToInt32(s[i]) + Convert.ToInt32(s[j])).ToString();
                    }
                }
            }

            Console.WriteLine($"{maxPair[0]} {maxPair[1]}");
        }
    }
}