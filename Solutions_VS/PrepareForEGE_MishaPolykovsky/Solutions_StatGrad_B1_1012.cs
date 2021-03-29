using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_StatGrad_B1_1012
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include)
        {
            ISolution.Start(new Solutions_StatGrad_B1_1012(), use, startupOptions);
        }

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if (((!x || y) == (!w || x)) && (!z || w))
                                Console.WriteLine($"{Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(w)} {Convert.ToInt32(x)}");
        }

        internal static void Solution_5()
        {
            for (int i = 20; i < 50; i++)
            {
                string temp = Convert.ToString(i, 2);

                temp += temp[^2].ToString();

                temp += temp[1].ToString();

                if (Convert.ToInt32(temp, 2) > 150)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_6()
        {
            int s, n, i;
            for (i = 1; i < 10; i++)
            {
                n = 36; s = i;
                while (s < 2020)
                {
                    s *= 2;
                    n += 3;
                }
                
                if (n == 60)
                    break;                   
            }
            
            Console.WriteLine(i);
        }

        internal static void Solution_8()
        {
            Console.WriteLine((from item in new[] { "0", "1", "2", "3", "4", "5", "6" }
                               from item1 in new[] { "0", "1", "2", "3", "4", "5", "6" }
                               from item2 in new[] { "0", "1", "2", "3", "4", "5", "6" }
                               from item3 in new[] { "0", "1", "2", "3", "4", "5", "6" }
                               from item4 in new[] { "0", "1", "2", "3", "4", "5", "6" }
                               select $"{item}{item1}{item2}{item3}{item4}")
                               .Distinct()
                                   .Where(item => Check(item))
                                       .Count());

            static bool Check(string item)
            {
                if ((item.Count(x => x == '6') == 1) && (item[0] != '6') && (item[^1] != '6'))
                    if ((item[item.IndexOf("6") + 1] != '2') && (item[item.IndexOf("6") - 1] != '2'))
                        return true;

                return false;
            }
        }

        internal static void Solution_12()
        {
            int[] min = new[] { 1000, 1000 };
            for (int i = 101; i < 1000; i++)
            {
                string s = String.Join("", Enumerable.Repeat("1", i));

                while (s.Contains("111"))
                {
                    s = new Regex("111").Replace(s, "22", 1);
                    s = new Regex("222").Replace(s, "11", 1);
                }

                if ((s.Count(x => x == '1') < min[0]) && (i < min[1]))
                {
                    min[0] = s.Count(x => x == '1');
                    min[1] = i;
                }
            }

            Console.WriteLine(min[1]);
        }

        internal static void Solution_14()
        {
            BigInteger f = BigInteger.Pow(343, 5) - BigInteger.Pow(7, 9) + 48;

            int count = 0;
            while (f != 0)
            {
                if (f % 7 == 6)
                    count++;

                f /= 7;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            //(ДЕЛ(90, A) /\ (¬ДЕЛ(x, A) → (ДЕЛ(x, 15) → ¬ДЕЛ(x, 20)))

            for (int a = 1000; a >= 0; a--)
            {
                bool flag = true;
                for (int x = 0; x < 1000; x++)
                {
                    if ((90 % a == 0 && (x % a == 0 || x % 15 != 0 || x % 20 != 0)) == false)
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
            Console.WriteLine(F(22));

            static int F(int n)
            {
                if (n == 0)
                    return 0;

                if (n % 3 == 0)
                    return n + F(n - 3);

                return n + F(n - (n % 3));
            }
        }

        internal static void Solution_17()
        {
            List<int> table = new List<int>() { 11, 13, 17, 19 }, res = new List<int>();
            for (int i = 11000; i < 22000; i++)
            {
                int d = 1, count = 0;
                while (d * d < i)
                {
                    if (i % d == 0)
                    {
                        if (table.Contains(d))
                            count++;
                        if (table.Contains(i / d))
                            count++;
                    }

                    d++;
                }
                
                if ((d * d == i) && table.Contains(d * d))
                    count++;

                if (count == 2)
                    res.Add(i);
            }

            Console.WriteLine($"{res.Count} {res.Min()}");
        }

        internal static void Solution_22()
        {
            int x, a;
            for (int i = 0; i < 1000; i++)
            {
                x = i;
                a = 1;
                while (x > 0)
                {
                    a *= x % 11;
                    x /= 11;
                }

                if (a == 120)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_24()
        {
            string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 10.12.2020\24\24.txt");

            Dictionary<char, int> counter = s.ToArray().Distinct().ToDictionary(x => x, x => (int)x);

            for (int i = 0; i < s.Length; i++)
                if (s[i] == 'A')
                    counter[s[i + 1]]++;

            Console.WriteLine(counter.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
        }

        internal static void Solution_25()
        {
            for (int i = 1000000; i < 2000000; i++)
            {
                int d = 1, count = 0;
                while (d * d < i)
                {
                    if (i % d == 0)
                    {
                        if (i / d - d < 100)
                            count++;
                    }

                    d++;
                }

                if (count > 2)
                    Console.WriteLine(i);
            }
        }
    }
}
