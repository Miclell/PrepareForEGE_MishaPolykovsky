using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_27
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_27(), use, startupOptions);

        internal static void Solution_2()
        {
            string[] s = File.ReadAllLines(@"/storage/emulated/0/Download/27-data/2/27-2b.txt");

            int[][] sn = s.Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value)).ToArray()).ToArray();

            List<int> difs = new();
            int sum = 0;
            for (int i = 1; i < s.Length; i++)
            {
                sum += Math.Max(sn[i][0], sn[i][1]);

                difs.Add(Math.Abs(sn[i][0] - sn[i][1]));
            }

            if (sum % 3 == 0)
                Console.WriteLine(sum);
            else
            {
                difs = difs.OrderBy(x => x).ToList();
                for (int i = 0; i < difs.Count; i++)
                    if ((sum - difs[i]) % 3 == 0)
                    {
                        Console.WriteLine(sum - difs[i]);
                        break;
                    }
            }
        }

        internal static void Solution_3()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\3\27-3a.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\3\27-3b.txt");

            int[][] sn = s.Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value)).ToArray()).ToArray();

            List<int> difs = new List<int>();

            int sum = 0;
            for (int i = 1; i < s.Length; i++)
            {
                sum += Math.Min(sn[i][0], sn[i][1]);

                difs.Add(Math.Abs(sn[i][0] - sn[i][1]));
            }

            if (sum % 3 == 0)
                Console.WriteLine(sum);
            else
                foreach (var dif in difs.OrderBy(x => x))
                    if ((sum + dif) % 3 == 0)
                    {
                        Console.WriteLine(sum + dif);
                        break;
                    }
        }

        internal static void Solution_7()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\7\27-7a.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\7\27-7b.txt");

            int[] sn = s.Select(x => int.Parse(x)).ToArray();

            int maxA = 0, maxB = 0;
            foreach (var i in sn.Skip(1))
            {
                if (i % 7 == 0 && i % 49 != 0 && i > maxA)
                    maxA = i;

                if (i % 7 != 0 && i > maxB)
                    maxB = i;
            }

            int R = maxA * maxB;
            if (R == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(R);
        }

        internal static void Solution_8()
        {
            int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\8\27-8a.txt")
                .Select(x => int.Parse(x)).ToArray();

            //int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\8\27-8b.txt")
            //    .Select(x => int.Parse(x)).ToArray();

            Tuple<int, int> minA = new(Int32.MaxValue, 0), minB = new(Int32.MaxValue, 0);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] < minA.Item1)
                    minA = new Tuple<int, int>(s[i], i);

                if (s[i] < minB.Item1 && i - minA.Item2 >= 5)
                    minB = new Tuple<int, int>(s[i], i);
            }

            Console.WriteLine(minA.Item1 * minA.Item1 + minB.Item1 * minB.Item1);
        }

        internal static void Solution_9()
        {
            //int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\9\27-9a.txt")
            //    .Select(x => int.Parse(x)).ToArray();

            int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\9\27-9b.txt")
                .Select(x => int.Parse(x)).ToArray();

            int minA = s[1], res = Int32.MaxValue;
            for (int i = 7; i < s.Length; i++)
            {
                if (s[i - 6] < minA)
                    minA = s[i - 6];

                int temp = s[i] * minA;
                if (temp % 2 != 0 && temp < res)
                    res = temp;
            }

            Console.WriteLine(res);

            res = Int32.MaxValue;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 6; j < s.Length; j++)
                {
                    int temp = s[i] * s[j];

                    if (temp % 2 != 0 && temp < res)
                        res = temp;
                }
            }

            Console.WriteLine(res);
        }

        internal static void Solution_10()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\10\27-10a.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\10\27-10b.txt");

            int[][] sn = s.Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value)).ToArray()).ToArray();

            List<int> difs = new();
            int sum = 0;
            foreach (var i in sn.Skip(1))
            {
                sum += Math.Max(i[0], i[1] > i[2] ? i[1] : i[2]);

                List<int> t = new() { i[0], i[1], i[2] };
                t = t.OrderByDescending(x => x).ToList();

                difs.Add(Math.Abs(t[0] - t[1]));
                difs.Add(Math.Abs(t[2] - t[0]));
            }

            if (sum % 4 != 0)
                Console.WriteLine(sum);
            else
                foreach (var dif in difs.OrderBy(x => x))
                    if ((sum - dif) % 4 != 0)
                    {
                        Console.WriteLine(sum - dif);
                        break;
                    }
        }

        internal static void Solution_11()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\11\27-11a.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\11\27-11b.txt");

            int[][] sn = s.Select(x => Regex.Matches(x, @"[0-9]+").Select(rm => int.Parse(rm.Value)).ToArray()).ToArray();

            List<int> difs = new();

            int sum = 0;
            foreach (var i in sn.Skip(1))
            {
                sum += Math.Max(i[0], i[1] > i[2] ? i[1] : i[2]);

                List<int> t = new() { i[0], i[1], i[2] };
                t = t.OrderByDescending(x => x).ToList();

                difs.Add(Math.Abs(t[0] - t[1]));
                difs.Add(Math.Abs(t[2] - t[0]));
            }

            if (sum % 8 == 0)
                Console.WriteLine(sum);
            else
                foreach (var dif in difs.OrderBy(x => x))
                    if ((sum - dif) % 8 == 0)
                    {
                        Console.WriteLine(sum - dif);
                        break;
                    }
        }

        internal static void Solution_12()
        {
            //int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\12\27-12a.txt")
            //   .Select(x => int.Parse(x)).ToArray();

            int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\12\27-12b.txt")
                .Select(x => int.Parse(x)).ToArray();

            int count = 0, count2 = 0, count3 = 0;
            foreach (var i in s.Skip(1))
            {
                if (i % 6 == 0)
                    count++;
                else if (i % 2 == 0)
                    count2++;
                else if (i % 3 == 0)
                    count3++;
            }

            Console.WriteLine(count2 * count3 + count * (s[0] - count) + count * (count - 1) / 2);
        }

        internal static void Solution_14()
        {
            string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\14\27-14a.txt");
            //string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\14\27-14b.txt");

            int count = 0;
            for (int i = 1; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)                   
                    if ((int.Parse(a[i]) + int.Parse(a[j])) % 12 == 0)
                        count++;

            Console.WriteLine(count);
        }

        internal static void Solution_17()
        {
            string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\17\27-17a.txt");
            //string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\17\27-17b.txt");

            int count = 0;
            for (int i = 1; i < a.Length; i++)
                for (int j = i + 5; j < a.Length; j++)
                    if ((int.Parse(a[i]) + int.Parse(a[j])) % 2 != 0 && (int.Parse(a[i]) * int.Parse(a[j])) % 13 == 0)
                        count++;

            Console.WriteLine(count);
        }

        internal static void Solution_18()
        {
            string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\18\27-18a.txt");
            //string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\18\27-18b.txt");

            int count = 0;
            for (int i = 1; i < a.Length; i++)
                for (int j = i + 1; j < i + 5 && j < a.Length; j++)
                    if ((int.Parse(a[i]) + int.Parse(a[j])) % 2 != 0 && (int.Parse(a[i]) * int.Parse(a[j])) % 13 == 0)
                        count++;

            Console.WriteLine(count);
        }

        internal static void Solution_35()
        {
            string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\35\27-35a.txt");
            //string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\35\27-35b.txt");

            int count = 0;
            for (int i = 1; i < a.Length; i++)
                for (int j = i + 2; j < a.Length; j++)
                    if (((int.Parse(a[i]) + int.Parse(a[j])) % 2 == 0) && a[(i + 1)..j].Contains("0") && !"0".Contains(a[i]) && !"0".Contains(a[j]))
                        count++;

            Console.WriteLine(count);
        }

        internal static void Solution_52()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\52\27.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\52\27-52a.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\52\27-52b.txt");

            List<int> sSorted = s.Skip(1).Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();

            int max = 0, count = 30;
            for (int i = 0; i < count; i++)
                for (int j = i + 1; j < count; j++)
                    for (int k = j + 1; k < count; k++)
                    {
                        int temp = sSorted[i] + sSorted[j] + sSorted[k];

                        if (temp % 3 == 0 && temp > max)
                            max = temp;
                    }

            Console.WriteLine(max);
        }

        internal static void Solution_54()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\54\27.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\54\27-54a.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\54\27-54b.txt");

            List<int> sSorted = s.Skip(1).Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();

            int max = 0, count = 30;
            for (int i = 0; i < count; i++)
                for (int j = i + 1; j < count; j++)
                    for (int k = j + 1; k < count; k++)
                        for (int f = k + 1; f < count; f++)
                        {
                            int temp = sSorted[i] + sSorted[j] + sSorted[k] + sSorted[f];
                            if (temp % 4 == 0 && temp > max)
                                max = temp;
                        }

            Console.WriteLine(max);
        }

        internal static void Solution_55()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\55\27.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\55\27-55a.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\55\27-55b.txt");

            List<int> sSorted = s.Skip(1).Select(x => int.Parse(x)).OrderBy(x => x).ToList();

            int min = int.MaxValue, count = 30;
            for (int i = 0; i < count; i++)
                for (int j = i + 1; j < count; j++)
                    for (int k = j + 1; k < count; k++)
                        for (int f = k + 1; f < count; f++)
                        {
                            int temp = sSorted[i] + sSorted[j] + sSorted[k] + sSorted[f];
                            if (temp % 4 == 0 && temp < min)
                                min = temp;
                        }

            Console.WriteLine(min);
        }

        internal static void Solution_59()
        {
            string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\59\27-59a.txt");
            //string[] a = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\59\27-59b.txt");

            List<int> rest = Enumerable.Repeat(0, 10).ToList();
            for (int i = 1; i < a.Length; i++)
            {
                List<int> restcopy = rest.ToList();
                for (int j = 0; j < 10; j++)
                    restcopy[(j + int.Parse(a[i])) % 10] += rest[j];

                restcopy[int.Parse(a[i]) % 10]++;

                rest = restcopy;
            }

            Console.WriteLine(rest[5]);
        }

        internal static void Solution_60()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\60\27.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\60\27-60a.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\60\27-60b.txt");

            int[] ss = s.Skip(1).Select(x => int.Parse(x.ToString())).ToArray();

            List<int> rest = Enumerable.Repeat(0, 25).ToList();
            for (int i = 0; i < ss.Length; i++)
            {
                List<int> restcopy = rest.ToList();
                for (int j = 0; j < rest.Count; j++)
                    if (rest[j] != 0)
                        restcopy[(j + ss[i]) % 25] = Math.Max(restcopy[(j + ss[i]) % 25], rest[j] + ss[i]);

                restcopy[ss[i] % 25] = Math.Max(restcopy[ss[i] % 25], ss[i]);

                rest = restcopy;
            }

            Console.WriteLine(rest[0]);
        }

        internal static void Solution_600()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\60\27.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\60\27-60a.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\60\27-60b.txt");

            List<int> sSorted = s.Skip(1).Select(x => int.Parse(x)).ToList();

            int sum = sSorted.Sum();

            if (sum % 25 != 0)
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < 50; i++)
                    numbers.Add(sSorted.Count(x => x == i));

                while (sum % 25 != 0)
                {
                    Console.Clear();
                    Console.WriteLine(sum);
                    Console.WriteLine(string.Join("\n", numbers.Select((x, y) => $"{y}: {x}")));

                    sum -= int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            Console.WriteLine(sum);
        }

        internal static void Solution_61()
        {
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27-61a.txt");
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27-61b.txt");

            List<int> rest = Enumerable.Repeat(0, 100).ToList();
            for (int i = 1; i < s.Length; i++)
            {
                List<int> restcopy = rest.ToList();
                for (int j = 0; j < 100; j++)
                    if (rest[j] != 0)
                        restcopy[(j + int.Parse(s[i])) % 100] = Math.Max(restcopy[(j + int.Parse(s[i])) % 100], rest[j] + int.Parse(s[i]));

                restcopy[int.Parse(s[i]) % 100] = Math.Max(restcopy[int.Parse(s[i]) % 100], int.Parse(s[i]));

                rest = restcopy;
            }

            Console.WriteLine(rest[50]);
        }

        internal static void Solution_611()
        {
            //int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27-61a.txt")
            //   .Select(x => int.Parse(x)).ToArray();

            int[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27-61b.txt")
                .Select(x => int.Parse(x)).ToArray();

            int sum = 0;
            foreach (var i in s.Skip(1))
                sum += i;

            bool flag = true;
            int temp = s.Max();
            List<int> sortedS = new();

            if (sum % 100 == 50)
            {
                Console.WriteLine(sum);
                flag = false;
            }
            else
            {
                sortedS = s.Skip(1).OrderBy(x => x).ToList();
                foreach (var i in sortedS)
                    if ((sum - i) % 100 == 50)
                    {
                        temp = i;
                        break;
                    }
            }

            if (flag)
            {
                sortedS = sortedS.GetRange(0, sortedS.IndexOf(temp) + 1);

                List<int> difs = new();
                for (int i = 0; i < sortedS.Count; i++)
                    for (int j = i + 1; j < sortedS.Count; j++)
                        for (int f = j + 1; f < sortedS.Count; f++)
                            if (sortedS[i] + sortedS[j] + sortedS[f] <= temp && (sum - sortedS[i] - sortedS[j] - sortedS[f]) % 100 == 50)
                                difs.Add(sum - sortedS[i] - sortedS[j] - sortedS[f]);

                Console.WriteLine(difs.Max());
            }
        }
    }
}