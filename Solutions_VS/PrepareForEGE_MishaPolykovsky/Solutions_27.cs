using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_27
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_27(), use, startupOptions);

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
            string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27-61a.txt");
            //string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\27data\61\27-61b.txt");

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
    }
}


