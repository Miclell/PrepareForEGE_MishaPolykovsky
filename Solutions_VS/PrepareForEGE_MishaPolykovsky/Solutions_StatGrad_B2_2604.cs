using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_StatGrad_B2_2604
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_StatGrad_B2_2604(), use, startupOptions);

        internal static void Solution_2()
        {
            bool[] table = new[] { false, true };

            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if ((!((!x || z) == (y && !w)) || (z && y)) == false)
                                Console.WriteLine($"{Convert.ToInt32(z)} {Convert.ToInt32(y)} {Convert.ToInt32(x)} {Convert.ToInt32(w)}");
        }
        
        internal static void Solution_5()
        {
            int count = 0;
            for (int i = 2; i < 100000; i++)
            {
                int t = i;

                if (t % 2 == 0)
                    t /= 2;
                else
                    t -= 1;

                if (t % 3 == 0)
                    t /= 3;
                else
                    t -= 1;

                if (t % 7 == 0)
                    t /= 7;
                else
                    t -= 1;

                if (t == 1)
                    count++;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_6()
        {
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    int s = j, x = i, n = 1;
                    s = 100 * s + x;
                    while (s < 2021)
                    {
                        s += 5 * n;
                        n++;
                    }

                    if (n == 17)
                        Console.WriteLine($"{i} {j}");
                }
            }
        }

        internal static void Solution_8()
        {
            string[] table = new[] { "Р", "У", "С", "Л", "А", "Н" };

            List<string> lst = new();
            foreach (var item in table)
                foreach (var item1 in table)
                    foreach (var item2 in table)
                        foreach (var item3 in table)
                            foreach (var item4 in table)
                                lst.Add($"{item}{item1}{item2}{item3}{item4}");

            int count = 0;

            foreach (var item in lst)
                if (item.Count(x => x == 'У') <= 1 &&
                    item.Count(x => x == 'А') <= 1)
                    count++;

            Console.WriteLine(count);
        }

        internal static void Solution_12()
        {
            Parallel.For(1, 50, (i, state) =>
            {
                Parallel.For(1, 50, j =>
                {
                    Parallel.For(1, 50, k =>
                    {
                        string s = "0" + String.Join("", Enumerable.Repeat("1", i)) + String.Join("", Enumerable.Repeat("2", j)) + String.Join("", Enumerable.Repeat("3", k)) + "0";

                        while (!s.Contains("00"))
                        {
                            s = new Regex("01").Replace(s, "210", 1);
                            s = new Regex("02").Replace(s, "320", 1);
                            s = new Regex("03").Replace(s, "3012", 1);
                        }

                        if (s.Count(x => x == '1') == 26 &&
                            s.Count(x => x == '2') == 54 &&
                            s.Count(x => x == '3') == 48)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                            state.Break();
                        }
                    });
                });
            });
        }

        internal static void Soluiton_14()
        {
            BigInteger a = BigInteger.Pow(729, 8) - BigInteger.Pow(3, 18) + 85;

            int count = 0;
            while (a != 0)
            {
                if (a % 9 == 0)
                    count++;

                a /= 9;
            }

            Console.WriteLine(count);
        }

        internal static void Soluiton_15()
        {
            for (int a = 0; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 0; x < 1000; x++)
                    if (((x & 49) != 0 || (x & 28) == 0 || (x & a) != 0) == false)
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
                if (n == 0)
                    return 0;

                if (n % 2 == 0)
                    return F(n / 2);

                return 1 + F(n - 1);
            }

            int count = 0;
            for (int i = 1; i <= 1000; i++)
                if (F(i) == 3)
                    count++;

            Console.WriteLine(count);
        }

        internal static void Solution_17()
        {
            int count = 0, min = Int32.MaxValue;
            for (int i = 123456; i <= 234567; i++)
            {
                int sum = i.ToString().Select(x => int.Parse(x.ToString())).Sum();

                if (i % sum == 0)
                {
                    count++;

                    min = Math.Min(i, min);
                }
            }

            Console.WriteLine($"{count} {min}");
        }

        internal static void Solution_22()
        {
            for (int i = 6; i < 1000; i++)
            {
                int x = i, a, b;
                a = 3 * x + 23;
                b = 3 * x - 17;
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
                
                if (a == 10)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_24()
        {
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 26.04.2021\24\24.txt");
            char[] alphabet = Enumerable.Range('A', 'Z' - 'A' + 1).Select(x => (char)x).ToArray();

            int max = 0;
            foreach (string line in s)
                if (line.Count(x => x == 'G') < 25)
                    foreach (char letter in alphabet)
                        max = Math.Max(max, line.LastIndexOf(letter) - line.IndexOf(letter));

            Console.WriteLine(max);
        }

        internal static void Solution_25()
        {
            for (int m = 0; m < 10000; m += 2)
                for (int n = 1; n < 10000; n += 2)
                {
                    double temp = Math.Pow(2, m) * Math.Pow(3, n);

                    if (temp <= 600000000 && temp >= 400000000)
                        Console.WriteLine(temp);
                }
        }

        internal static void Solution_26()
        {
            List<int> s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 26.04.2021\26\26.txt").Select(x => int.Parse(x.ToString())).Skip(1).OrderBy(x => x).ToList();
            
            int count = 0, max = 0;
            for (int i = 0; i < s.Count; i++)
                for (int j = i + 1; j < s.Count; j++)
                    if (s[i] % 2 == s[j] % 2 && 
                        s.BinarySearch(s[i] + s[j]) >= 0)
                    {
                        count++;

                        max = Math.Max(max, s[i] + s[j]);
                    }

            Console.WriteLine($"{count} {max}");
        }

        internal static void Solution_27()
        {
            static List<List<int>> Sort(List<List<int>> n)
            {
                for (int i = 0; i < n.Count; i++)
                    for (int j = i + 1; j < n.Count; j++)
                        if (n[i][2] > n[j][2])
                        {
                            var temp = n[j];
                            n[j] = n[i];
                            n[i] = temp;
                        }

                return n;
            }

            int[][] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 26.04.2021\27\27-B.txt").Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value.ToString())).ToArray()).Skip(1).Where(item => item[1] % 2 != 0).ToArray();

            List<List<int>> lst = new();

            int sumx = 0, sumi = 0;
            foreach (var item in s)
            {
                sumx += Math.Max(item[0], item[1]);
                sumi += Math.Min(item[0], item[1]);
                lst.Add(new List<int>() { item[0], item[1], item[0] + item[1] });
            }

            if (sumx % 2 == 0 && sumi % 2 != 0)
                Console.WriteLine(sumx + sumi);
            else
            {
                Console.WriteLine($"{sumx} {sumi} {sumx + sumi}");

                lst = Sort(lst);
                Console.WriteLine($"{String.Join(" ", lst[0])} \n{String.Join(" ", lst[1])}");
            }
        }
    }
}
