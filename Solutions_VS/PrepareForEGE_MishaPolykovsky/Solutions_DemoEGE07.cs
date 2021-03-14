using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.IO;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_DemoEGE07
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_DemoEGE07(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if (((!x && !y) || (y == z) || w) == false)
                                Console.WriteLine("{0} {1} {2} {3}", Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(z), Convert.ToInt32(w));
        }

        internal static void Solution_6()
        {
            for (int d = 100; d > 0; d--)
            {
                int n = 5, s = 83;

                while (s <= 1200)
                {
                    s += d;
                    n += 6;
                }

                if (n == 89)
                {
                    Console.WriteLine(d);
                    break;
                }
            }
        }        

        internal static void Solution_8()
        {
            int[] table = new[] { 1, 2, 3, 4 };

            int count = 0;
            foreach (int a in table)
                foreach (int b in table)
                    foreach (int v in table)
                    {
                        //Console.WriteLine($"{a} {b} {v}");
                        if (a != 4)
                            count++;
                    }

            Console.WriteLine(count);
        }

        internal static void Solution_12()
        {
            string s = "";
            for (int i = 0; i < 125; i++)
                s += "8";

            while ((s.IndexOf("222") != -1) || (s.IndexOf("888") != -1))
            {
                for (int i = 0; i < s.Length - 3; i++)
                {
                    if ((s[i] == '2') && (s[i + 1] == '2') && (s[i + 2] == '2'))
                    {
                        s = s.Remove(i, 3);
                        s = s.Insert(i, "8");
                        i = 0;
                    }
                    else if ((s[i] == '8') && (s[i + 1] == '8') && (s[i + 2] == '8'))
                    {
                        s = s.Remove(i, 3);
                        s = s.Insert(i, "2");
                        i = 0;
                    }
                }
            }

            Console.WriteLine(s);
        }

        internal static void Solution_14()
        {
            BigInteger a = BigInteger.Pow(4, 14) + BigInteger.Pow(64, 16) - 81;
            int b = 0;

            while (a > 0)
            {
                if (a % 4 == 3)
                    b++;
                a /= 4;
            }

            Console.WriteLine(b);
        }

        internal static void Solution_15()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                    for (int y = 1; y < 100; y++)
                        if (((y + 2 * x != 99) || (a < x) || (a < y)) == false)
                            flag = false;

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_16()
        {
            static int F(int n)
            {
                if (n < 4)
                    return n - 1;

                return F(n - 2) + G(n - 1);
            }

            static int G(int n)
            {
                if (n < 3)
                    return n + 1;

                return G(n - 2) + F(n - 1);
            }

            Console.WriteLine(F(25));
        }

        internal static void Solution_17()
        {
            int min = 2044, count = 0;

            for (int i = 1024; i <= 2048; i++)
            {
                if ((i % 7 == 0) && (i % 11 != 0) && (i % 19 != 0))
                {
                    if (i < min)
                        min = i;
                    count++;
                }
            }

            Console.WriteLine($"{min} {count}");
        }

        internal static void Solution_22()
        {
            for (int i = 1; i < 1000; i++)
            {
                int a = 0, b = 1, x = i;
                while (x > 0)
                {
                    a++;
                    b *= x % 9;
                    x /= 9;
                }

                if ((a == 3) && (b == 18))
                {
                    Console.WriteLine(i);
                    break;
                }
            }            
        }

        internal static void Solution_23()
        {
            static bool CheckNumber(string path)
            {
                int result = 3;
                bool[] superflag = new[] { false, false };

                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == '1')
                        result *= 2;
                    else
                        result += 1;

                    if ((result == 10) || (result == 15))
                    {
                        if (superflag[0])
                            superflag[1] = true;
                        else
                            superflag[0] = true;
                    }
                }

                if ((result == 36) && (superflag[0] == true) && (superflag[1] == true))
                    return true;
                else
                    return false;
            }

            int count = 0;
            bool[] table = new[] { false, true };
            string s = "";

            while (true)
            {
                for (int i = 0; i < 32; i++/*, unchecked(table[1] = Convert.ToBoolean(Convert.ToInt32(table[1]) + 1))*/)
                {
                    foreach (var q in table)
                        s += q.ToString();
                }                
            }
        } //не робит страшилка, просто неккоретный цикл, надо делать рекурсию

        internal static void Solution_24()
        {
            string path = @"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Файлы\Задание 24\24.txt";

            File.OpenRead(path);
            string s = File.ReadAllText(path);

            int count = 0, max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'X')
                    count++;
                else if (count > max)
                {
                    max = count;
                    count = 0;
                }
                else
                    count = 0;
            }

            Console.WriteLine(max);
        }

        internal static void Solution_25()
        {
            static int[] Solve(int n, out bool flag)
            {
                List<int> dels = new List<int>();

                int count = 0;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                        dels.Add(i);
                    }

                    if (count > 2)
                        break;
                }

                if (count == 2)
                {
                    flag = true;
                    return dels.ToArray();                    
                }
                else
                {
                    flag = false;
                    return dels.ToArray();
                }
            }

            for (int i = 19960; i < 20000; i++)
            {
                int[] arr = Solve(i, out bool flag);

                if (flag)
                {
                    Console.WriteLine($"{arr[0]} {arr[1]}");
                }
            }
        }

        internal static void Solution_27()
        {
            string path1 = @"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Файлы\Задание 27\27-A.txt";
            string path2 = @"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Файлы\Задание 27\27-B.txt";

            static void Solve(string path)
            {
                File.OpenRead(path);
                string[] lines = File.ReadAllLines(path);

                int[] linesInt = new int[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    linesInt[i] = int.Parse(lines[i]);
                }

                int count = 0;
                for (int i = 0; i < linesInt.Length; i++)
                {
                    for (int j = i + 3; j < linesInt.Length; j++)
                    {
                        if ((i * j) % 17 == 0)
                            count++;
                    }
                }

                Console.WriteLine(count);
            }

            Solve(path1);
            Solve(path2);
        }
    }
}