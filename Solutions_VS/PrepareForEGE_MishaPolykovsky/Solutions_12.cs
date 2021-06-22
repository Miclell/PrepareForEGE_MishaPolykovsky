using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_12
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
               ISolution.Start(new Solutions_12(), use, startupOptions);

        internal static void Solution_78()
        {
            static bool Check(int i, int j, int goI, int goJ)
            {
                if (((i == 4) && (j == 1) && (goI == 4) && (goJ == 2)) ||
                    ((i == 4) && (j == 2) && (goI == 4) && (goJ == 1)) ||
                    ((i == 4) && (j == 2) && (goI == 3) && (goJ == 2)) ||
                    ((i == 3) && (j == 2) && (goI == 4) && (goJ == 2)) ||
                    ((i == 1) && (j == 2) && (goI == 1) && (goJ == 3)) ||
                    ((i == 1) && (j == 3) && (goI == 1) && (goJ == 2)) ||
                    ((i == 6) && (j == 3) && (goI == 5) && (goJ == 3)) ||
                    ((i == 5) && (j == 3) && (goI == 6) && (goJ == 3)) ||
                    ((i == 5) && (j == 3) && (goI == 5) && (goJ == 4)) ||
                    ((i == 5) && (j == 4) && (goI == 5) && (goJ == 3)) ||
                    ((i == 4) && (j == 3) && (goI == 4) && (goJ == 4)) ||
                    ((i == 4) && (j == 4) && (goI == 4) && (goJ == 3)) ||
                    ((i == 4) && (j == 4) && (goI == 3) && (goJ == 4)) ||
                    ((i == 3) && (j == 4) && (goI == 4) && (goJ == 4)) ||
                    ((i == 3) && (j == 4) && (goI == 3) && (goJ == 5)) ||
                    ((i == 3) && (j == 5) && (goI == 3) && (goJ == 4)) ||
                    ((i == 2) && (j == 4) && (goI == 2) && (goJ == 5)) ||
                    ((i == 2) && (j == 5) && (goI == 2) && (goJ == 4)) ||
                    ((i == 5) && (j == 5) && (goI == 5) && (goJ == 6)) ||
                    ((i == 5) && (j == 6) && (goI == 5) && (goJ == 5)) ||
                    ((i == 4) && (j == 5) && (goI == 4) && (goJ == 6)) ||
                    ((i == 4) && (j == 6) && (goI == 4) && (goJ == 5)) ||
                    ((i == 1) && (j == 6) && (goI == 2) && (goJ == 6)) ||
                    ((i == 2) && (j == 6) && (goI == 1) && (goJ == 6)) ||
                    ((i == 1) && (j == 6) && (goI == 1) && (goJ == 7)) ||
                    ((i == 2) && (j == 6) && (goI == 2) && (goJ == 7)) ||
                    ((i == 3) && (j == 6) && (goI == 3) && (goJ == 7)) ||
                    ((i == 4) && (j == 6) && (goI == 4) && (goJ == 7)) ||
                    ((i == 5) && (j == 6) && (goI == 5) && (goJ == 7)) ||
                    ((i == 6) && (j == 6) && (goI == 6) && (goJ == 7)) ||
                    ((i == 6) && (j == 1) && (goI == 7) && (goJ == 1)) ||
                    ((i == 6) && (j == 2) && (goI == 7) && (goJ == 2)) ||
                    ((i == 6) && (j == 3) && (goI == 7) && (goJ == 3)) ||
                    ((i == 6) && (j == 4) && (goI == 7) && (goJ == 4)) ||
                    ((i == 6) && (j == 5) && (goI == 7) && (goJ == 5)) ||
                    ((i == 6) && (j == 6) && (goI == 7) && (goJ == 6))
                    )
                    return false;

                return true;
            }

            int[] lastPoz = new int[2];

            int count = 0;
            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                {
                    lastPoz[0] = i;
                    lastPoz[1] = j;

                    bool flag = true;

                    while ((Check(lastPoz[0], lastPoz[1], lastPoz[0], lastPoz[1] + 1) || Check(lastPoz[0], lastPoz[1], lastPoz[0] + 1, lastPoz[1])) && flag)
                    {
                        while ((Check(lastPoz[0], lastPoz[1], lastPoz[0], lastPoz[1] + 1)) && flag)
                            if ((Check(lastPoz[0], lastPoz[1], lastPoz[0], lastPoz[1] + 1)) && flag)
                                lastPoz[1] += 1;
                            else
                            {
                                flag = false;
                                break;
                            }

                        if (Check(lastPoz[0], lastPoz[1], lastPoz[0] + 1, lastPoz[1]) && flag)
                            lastPoz[0] += 1;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }

                    if ((lastPoz[0] == 6) && (lastPoz[1] == 6) && flag)
                        count++;
                }

            Console.WriteLine(count);
        }

        internal static void Solution_174()
        {
            string s = "1" + string.Join("", Enumerable.Repeat("0", 75).ToArray()); //черная магия линки:))

            while (s.Contains("10") || s.Contains("1"))
                if (s.Contains("10"))
                    s = s.Replace("10", "001");
                else
                    s = s.Replace("1", "00");

            Console.WriteLine(s.Count(str => str == '0')); //черная магия линки:))
        }

        internal static void Solution_233()
        {
            static int F(string s)
            {
                int way1 = 0, way2 = 0;

                if (s.Count(x => x == '1') < 23)
                    way1 = F(s + "1");

                if (s.Count(x => x == '2') < 5)
                    way2 = F(s + "2");

                if (s.Count(x => x == '1') == 23 && 
                    s.Count(x => x == '2') == 5)
                {
                    while (s.Contains("11"))
                    {
                        if (s.Contains("112"))
                            s = new Regex("112").Replace(s, "5", 1);
                        else
                            s = new Regex("11").Replace(s, "3", 1);
                    }

                    return s.Select(x => int.Parse(x.ToString())).Sum();
                }

                return Math.Max(way1, way2);
            }

            Console.WriteLine(F(""));
        }

        internal static void Solution_234()
        {
            static int F(string s)
            {
                int f1 = 0, f2 = 0;

                if (s.Count(x => x == '1') < 25)
                    f1 = F(s + "1");

                if (s.Count(x => x == '2') < 8)
                    f2 = F(s + "2");

                if (s.Count(x => x == '1') == 25 && s.Count(x => x == '2') == 8)
                {
                    while (s.Contains("11"))
                    {
                        if (s.Contains("112"))
                            s = new Regex("112").Replace(s, "5", 1);
                        else
                            s = new Regex("11").Replace(s, "7", 1);
                    }

                    return s.Select(x => int.Parse(x.ToString())).Sum();
                }

                return Math.Max(f1, f2);
            }

            Console.WriteLine(F(""));
        }

        internal static void Solution_235()
        {
            string s = ">" + String.Join("", Enumerable.Repeat("1", 10)) + String.Join("", Enumerable.Repeat("2", 20)) + String.Join("", Enumerable.Repeat("3", 30));

            while (s.Contains(">1") || s.Contains(">2") || s.Contains(">3"))
            {
                if (s.Contains(">1"))
                    s = new Regex(">1").Replace(s, "22>", 1);

                if (s.Contains(">2"))
                    s = new Regex(">2").Replace(s, "2>", 1);

                if (s.Contains(">3"))
                    s = new Regex(">3").Replace(s, "1>", 1);
            }

            Console.WriteLine(s.Select(x => x != '>' ? int.Parse(x.ToString()) : 0).Sum());
        }

        internal static void Solution_253()
        {
            static string Temp(string s)
            {
                while (s.Contains("111"))
                {
                    s = new Regex("111").Replace(s, "2", 1);

                    s = new Regex("2222").Replace(s, "333", 1);

                    s = new Regex("33").Replace(s, "1", 1);
                }

                return s;
            }

            int min = Int32.MaxValue; ;
            for (int i = 100; i < 1000; i++)
            {
                string s = String.Join("", Enumerable.Repeat("1", i));

                int temp = Temp(s).Count(x => x == '1');

                min = temp < min ? temp : min;
            }

            for (int i = 100; i < 150; i++)
            {
                string s = String.Join("", Enumerable.Repeat("1", i));

                int temp = Temp(s).Count(x => x == '1');

                if (min == temp)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        internal static void Solution_256()
        {
            static string Temp(string s)
            {
                while (s.Contains("333") || s.Contains("111"))
                {
                    s = new Regex("333").Replace(s, "11", 1);

                    s = new Regex("111").Replace(s, "3", 1);
                }

                return s;
            }

            string s = "", max = "";
            for (int i = 1; i < 150; i++)
            {
                s = String.Join("", Enumerable.Repeat("1", i));

                s = Temp(s);

                if (s.Length > max.Length)
                    max = s;
            }

            for (int i = 100; i < 150; i++)
            {
                s = String.Join("", Enumerable.Repeat("1", i));

                s = Temp(s);

                if (s.Length == max.Length)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}