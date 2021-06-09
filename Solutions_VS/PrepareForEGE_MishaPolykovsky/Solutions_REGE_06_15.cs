using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_REGE_06_15
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_REGE_06_15(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { true, false };

            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if (((!x || !y || !z || w) && (w || x || !y)) == false)
                                Console.WriteLine($"{Convert.ToInt32(z)} {Convert.ToInt32(w)} {Convert.ToInt32(y)} {Convert.ToInt32(x)}");
        }

        internal static void Solution_6()
        {
            int s = 0, n = 32;
            while (n > s)
            {
                s++;
                n--;
            }

            Console.WriteLine(n);
        }

        internal static void Solution_12()
        {
            string s = "1" + String.Join("", Enumerable.Repeat("8", 99)) + "1";

            while (s.Contains("81") || s.Contains("882") || s.Contains("8883"))
            {
                if (s.Contains("81"))
                    s = new Regex("81").Replace(s, "2", 1);
                else if (s.Contains("882"))
                    s = new Regex("882").Replace(s, "3", 1);
                else
                    s = new Regex("8883").Replace(s, "1", 1);
            }

            Console.WriteLine(s);
        }

        internal static void Solution_15()
        {
            for (int a = 0; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 10000; x++)
                {
                    if (((x & 51) == 0 || (x & 41) != 0 || (x & a) == 0) == false)
                        flag = false;
                }

                if (flag)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }

        internal static void Soluiton_16()
        {
            static int F(int n)
            {
                if (n > 2)
                    return F(n - 1) + G(n - 2);
                else 
                    return n + 1;
            }

            static int G(int n)
            {
                if (n > 2)
                    return G(n - 1) + F(n - 2);
                else 
                    return n;
            }

            Console.WriteLine(G(7));
        }

        internal static void Solution_17()
        {
            int count = 0, min = 9406;
            for (int i = 7286; i <= 9405; i++)
            {
                if (i % 13 == 0 && i % 15 == 0 &&
                    i % 7 != 0 && i % 17 != 0 && i % 20 != 0 && i % 27 != 0)
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
                int x = i, a = 0, b = 1;
                while (x > 0)
                {
                    a++;
                    b *= x % 1000;
                    x /= 1000;
                }

                if (a == 2 && b == 11)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\РЕГЭ 06.15\24\24.txt");
        
            Console.WriteLine(Regex.Matches(s, @"Y*").Select(x => x.Value.Length).Max());
        }

        internal static void Solution_25()
        {
            Tuple<int, int> temp = new(0, 0);
            for (int i = 120115; i <= 120200; i++)
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

                if (count > temp.Item2)
                {
                    temp = new(i, count);
                }
            }

            int d1 = 1, count1 = 0;
            while (d1 * d1 < temp.Item1)
            {
                if (temp.Item1 % d1 == 0)
                    count1 += 2;

                d1++;
            }

            if (d1 * d1 == temp.Item1)
                count1++;

            Console.WriteLine($"{temp.Item1} {count1}");
        }

        internal static void Solution_27()
        {
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\РЕГЭ 06.15\27\28131_A.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\РЕГЭ 06.15\27\28131_B.txt");

            List<int> a = s.Select(x => int.Parse(x)).ToList();

            a = a.OrderByDescending(x => x).ToList();

            int count = 20, max = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                    if ((a[i] + a[j]) % 120 == 0)
                        max = Math.Max(max, a[i] + a[j]);
            }

            Console.WriteLine(max);
        }
    }
}
