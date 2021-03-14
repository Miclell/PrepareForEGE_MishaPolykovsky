using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_StatGrad_B1_2210
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include)
        {
            ISolution.Start(new Solutions_StatGrad_B1_2210(), use, startupOptions);
        }

        internal static void Solution_2()
        {
            //(w \/ ¬x) /\ (w ≡ ¬y) /\ (w → z)

            bool[] table = new[] { true, false };
            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if ((w || !x) && (w == !y) && (!w || z))
                                Console.WriteLine($"{Convert.ToInt32(w)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(x)}");
        }

        internal static void Solution_5()
        {
            for (int i = 171; ; i++)
            {
                string s = Convert.ToString(i, 2);

                if (((s[0..^1].Count(x => x == '1') % 2).ToString() == s[^1].ToString()) &&
                    ((s[0..^2].Count(x => x == '1') % 2).ToString() == s[^2].ToString()))
                {
                    Console.WriteLine(Convert.ToInt32(s[0..^2], 2));
                    break;
                }
            }
        }

        internal static void Solution_6()
        {
            //128
            int i;
            for (i = 0; i < 1000; i++)
            {
                int s = i, n = 4;
                while (s < 37)
                {
                    s += 3;
                    n *= 2;
                }

                if (n == 128)
                    goto Finsish;
            }

        Finsish:
            Console.WriteLine(i);
        }

        internal static void Solution_8()
        {
            string[] table = new[] { "А", "Н", "Д", "Р", "Е", "Й" };

            List<string> res = new List<string>();
            int count = 0;

            foreach (var item1 in table)
                foreach (var item2 in table)
                    foreach (var item3 in table)
                        foreach (var item4 in table)
                            foreach (var item5 in table)
                                foreach (var item6 in table)
                                    foreach (var item7 in table)
                                        res.Add(item1 + item2 + item3 + item4 + item5 + item6 + item7);

            for (int i = 0; i < res.Count; i++)
                if ((res[i][0] != 'Й') && (res[i].Count(x => x == 'А') == 1) && (res[i].Count(x => x == 'Й') == 1))
                    count++;

            Console.WriteLine(count);
        }

        internal static void Solution_12()
        {
            string s = string.Join("", Enumerable.Repeat("1", 99));

            while (s.Contains("111"))
            {
                s = new Regex("111").Replace(s, "22", 1);
                s = new Regex("222").Replace(s, "11", 1);
            }

            Console.WriteLine(s);
            //Regex(какое заменяем).Replace(где заменяем, на что, сколько вхождений);
        }

        internal static void Solution_14()
        {
            BigInteger a = BigInteger.Pow(81, 17) + BigInteger.Pow(3, 24) - 45;

            int count = 0;
            while (a != 0)
            {
                if (a % 9 == 8)
                    count++;

                a /= 9;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            //(A < 50) /\ (¬ДЕЛ(x, A) → (ДЕЛ(x, 10) → ¬ДЕЛ(x, 12)))


            for (int a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 0; x < 1000; x++)
                {
                    if (((a < 50) && ((x % a == 0) || (x % 10 != 0) || (x % 12 != 0))) == false)
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
            //F(1) = 1;
            //F(n) = n + F(n–2), если n > 1 и при этом n нечётно;
            //F(n) = n × F(n–1), если n чётно

            static int F(int n)
            {
                if (n == 1)
                    return 1;

                if (n % 2 != 0)
                    return n + F(n - 2);

                return n * F(n - 1);
            }

            Console.WriteLine(F(60));
        }

        internal static void Solution_17()
        {
            long count = 0, min = 400000;
            for (long i = 200000; i < 400000 + 1; i++)
            {
                if ((i % 7 == 0) &&
                    (i % 13 != 0) && (i % 29 != 0) &&
                    (i % 43 != 0) && (i % 101 != 0))
                {
                    count++;
                    if (i < min)
                        min = i;
                }
            }

            Console.WriteLine($"{count} {min * 100000}");
        }

        internal static void Solution_18()
        {
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 22.10.2020.(Ф.)\18\18.txt");

            decimal count = Convert.ToDecimal(s[0]), max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (Convert.ToDecimal(s[i]) < Convert.ToDecimal(s[i - 1]))
                    count += Convert.ToDecimal(s[i]);
                else
                {
                    if (count > max)
                        max = count;

                    count = Convert.ToDecimal(s[i]);
                }
            }

            if (count > max)
                max = count;

            Console.WriteLine((int)max);
        }

        internal static void Solution_22()
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = i, a = 1;
                while (x > 0)
                {
                    a *= x % 7;
                    x /= 7;
                }

                if (a == 48)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_23()
        {
            List<int> res = new List<int>() { 0, 1 };
            for (int i = 0; i < 70; i++)
                res.Add(0);

            for (int i = 1; i < 22; i++)
            {
                if (i + 1 <= 22)
                    res[i + 1] += res[i];
                if (i * 3 <= 22)
                    res[i * 3] += res[i];
            }

            for (int i = 22; i <= 70; i++)
            {
                if (i + 1 <= 70)
                    res[i + 1] += res[i];
                if (i * 3 <= 70)
                    res[i * 3] += res[i];
            }

            Console.WriteLine(res[70]);
        }

        internal static void Solution_24()
        {
//            Определите количество строк, в которых буква E
//            встречается чаще, чем буква A.

            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Solutions\PrepareForEGE_MishaPolykovsky\Others_Solutions\Ст. Инф. 22.10.2020.(Ф.)\24\24.txt");
            
            int count = 0, counterA = 0, counterE = 0;
            for (int i = 0; i < s.Length; i++)
            {
                foreach (char item in s[i])
                {
                    if (item == 'A')
                        counterA++;

                    if (item == 'E')
                        counterE++;
                }

                if (counterE > counterA)
                    count++;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_25()
        {
            //123456789 223456789

            List<int> res = new List<int>();
            for (int i = (int)Math.Pow(123456789, 0.25); i < (int)Math.Pow(223456789, 0.25) + 1; i++)
            {
                int x = (int)Math.Pow(i, 4), d = 2;

                bool flag = true;
                while (d * d <= i)
                {
                    if (x % d == 0)
                        flag = false;

                    d++;
                }

                if (flag)
                    res.Add(new List<int>() { (int)Math.Pow(i, 2), (int)Math.Pow(i, 3) }.Max());
            }

            foreach (var item in res)
                Console.WriteLine(item);
        }
    }
}
