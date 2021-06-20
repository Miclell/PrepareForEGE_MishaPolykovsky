using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_Open_Variant
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_Open_Variant(), use, startupOptions);

        internal static void Solution_12()
        {
            string s = String.Join("", Enumerable.Repeat("1", 81));

            while (s.Contains("1111") || s.Contains("88888"))
            {
                if (s.Contains("1111"))
                    s = new Regex("1111").Replace(s, "888", 1);
                else
                    s = new Regex("88888").Replace(s, "888", 1);
            }

            Console.WriteLine(s);
        }

        internal static void Solution_14()
        {
            BigInteger a = 7 * BigInteger.Pow(512, 120) - 6 * BigInteger.Pow(64, 100) + BigInteger.Pow(8, 210) - 255;

            int count = 0;
            while (a != 0)
            {
                count = a % 8 == 0 ? ++count : count;

                a /= 8;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_16()
        {
            static int F(int n)
            {
                if (n == 1)
                    return 1;

                if (n % 2 == 0)
                    return n + F(n - 1);

                return 2 * F(n - 2);
            }

            Console.WriteLine(F(24));
        }

        internal static void Solution_17()
        {
            int count = 0, min = Int32.MaxValue;
            for (int i = 16015; i <= 48989; i++)
            {
                if ((i % 7 == 0 || i % 11 == 0) && 
                    i % 9 != 0 && i % 12 != 0 && i % 13 != 0)
                {
                    min = i < min ? i : min;
                    count++;
                }
            }

            Console.WriteLine($"{count} {min}");
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Открытый вариант\inf\Задание 24\24.txt");

            int count = 3, max = 0;
            for (int i = 0; i < s.Length - 3; i++)
                if (s[i..(i + 4)] != "XZZY")
                    max = Math.Max(++count, max);
                else
                    count = 3;

            Console.WriteLine(max);

            Console.WriteLine(Regex.Matches(s, @"((?!XZZY).)*").Select(x => x.Value.Length).Max() + 3);
        }

        internal static void Solution_25()
        {
            int count = 0;
            for (int i = 452021; count != 5; i++)
            {
                for (int d = 2; d * d < i; d++)
                {
                    if (i % d == 0)
                    {
                        int m = d + (i / d);
                        if (m % 7 == 3)
                        {
                            Console.WriteLine($"{i} {m}");
                            count++;
                        }      

                        break;                  
                    }                    
                }
            }
        }

        internal static void Solution_27()
        { 
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Открытый вариант\inf\Задание 27\27_A.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Открытый вариант\inf\Задание 27\27_B.txt");

            int[][] sn = s.Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value)).ToArray()).ToArray();
            List<int> difs = new();
            long sum = 0;
            foreach (var i in sn.Skip(1))
            {
                int maxT = i.Max();
                int min = i.Min();
                int cr = i.Sum() - i.Max() - i.Min();

                sum += maxT;

                difs.Add(maxT - min);
                difs.Add(maxT - cr);
            }

            long max = 0;
            foreach (var dif in difs)
            {
                long temp = sum - dif;
                if (temp % 109 != 0 && temp > max)
                    max = temp;
            }

            Console.WriteLine(max);
        }
    }
}
