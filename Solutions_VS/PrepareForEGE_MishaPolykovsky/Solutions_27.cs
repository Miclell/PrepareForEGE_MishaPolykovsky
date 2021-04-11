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
                    if (((int.Parse(a[i]) + int.Parse(a[j])) % 2 == 0) && a[(i + 1)..j].Contains("0"))
                        count++;

            Console.WriteLine(count);
        } //нет ошибок, ответ почти правильный
    }
}
