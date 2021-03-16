﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_25
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_25(), use, startupOptions);

        internal static void Solution_4()
        {
            //209834; 209857
            for (int i = 209834; i <= 209857; i++)
            {
                List<int> dels = new List<int>();

                int d;
                for (d = 1; d * d <= i; d++)
                {
                    if (i % d == 0)
                        dels.AddRange(new List<int>() { d, i / d });

                    if (dels.Count > 4)
                        break;
                }

                if (d * d == i)
                    dels.Add(d);

                dels.Sort();
                if (dels.Count == 4)
                    Console.WriteLine($"{dels[0]} {dels[1]} {dels[2]} {dels[3]}");
            }
        }

        internal static void Solution_17()
        {
            //157898; 157990
            for (int i = 157898; i <= 157990; i++)
            {
                List<int> dels = new List<int>();

                int d;
                for (d = 1; d * d < i; d++)
                {
                    if (i % d == 0)
                        dels.AddRange(new List<int>() { d, i / d });

                    if (dels.Count > 6)
                        break;
                }

                if (d * d == i)
                    dels.Add(d);

                dels.Sort();
                if (dels.Count == 6)
                    Console.WriteLine($"{dels[0]} {dels[1]} {dels[2]} {dels[3]} {dels[4]} {dels[5]}");
            }
        }

        internal static void Solution_23()
        {
            //190061; 190080
            for (int i = 190061; i <= 190080; i++)
            {
                List<int> dels = new List<int>();

                int d;
                for (d = 1; d * d <= i; d += 2)
                {
                    if (i % d == 0)
                        dels.AddRange(new List<int>() { d, i / d });

                    if (dels.Count > 4)
                        break;
                }

                if (d * d == i)
                    dels.Add(d);

                if (dels.Count == 4)
                    Console.WriteLine($"{dels[0]} {dels[1]} {dels[2]} {dels[3]}");
            }
        }

        internal static void Solution_27()
        {
            //125873; 136762
            for (int i = (int)Math.Sqrt(125873); i <= (int)Math.Sqrt(136762); i++)
            {
                List<int> dels = new List<int>();

                int d, x = i * i;
                for (d = 1; d * d < x; d++)
                {
                    if (x % d == 0)
                        dels.AddRange(new List<int>() { d, x / d });

                    if (dels.Count > 5)
                        break;
                }

                if (d * d == x)
                    dels.Add(d);

                dels.Sort();
                if (dels.Count == 5)
                    Console.WriteLine($"{dels[0]} {dels[1]} {dels[2]} {dels[3]} {dels[4]}");
            }
        }

        internal static void Solution_44()
        {
            //4837177 4837236
            for (int i = 4837177; i <= 4837236; i++)
            {
                int d, count = 0;
                for (d = 1; d * d <= i; d++)
                {
                    if (i % d == 0)
                        count += 2;

                    if (count > 2)
                        break;
                }

                if (d * d == i)
                    continue;

                if (count == 2)
                    Console.WriteLine(i);
            }
        }

        internal static void Solution_63()
        {
            //2532000; 2532160
            for (int col = 0, i = 2532000; i <= 2532160; i++)
            {
                int d, count = 0;
                for (d = 1; d * d <= i; d++)
                {
                    if (i % d == 0)
                        count += 2;

                    if (count > 2)
                        break;
                }

                if (d * d == i)
                    continue;

                if ((count == 2) && (col < 5))
                {
                    col++;
                    Console.WriteLine($"{col} {i}");
                }
            }
        }

        internal static void Solution_97()
        {
            //135790; 163228
            for (int i = 135790; i <= 163228; i++)
            {
                List<int> dels = new List<int>();

                int d;
                for (d = 2; d * d < i; d++)
                {
                    if (i % d == 0)
                        dels.AddRange(new List<int>() { d, i / d });
                }

                if (d * d == i)
                    dels.Add(d);

                if (dels.Sum(x => x) > 460000)
                    Console.WriteLine($"{dels.Count} {dels.Sum(x => x)}");
            }
        }

        internal static void Solution_123()
        {
            Console.WriteLine(Check(new List<int>() { 2, 3, 5 }, 30));

            //416782; 498324
            int max = 0, min = 498325;
            List<int> numb = new List<int>();
            for (int i = 416782; i < 498324; i++)
            {
                List<int> dels = new List<int>();

                int d;
                for (d = 1; d * d < i; d++)
                {
                    if (d % i == 0)
                        dels.AddRange(new List<int>() { d, i / d });
                }

                if (d * d == i)
                    dels.Add(d);

                if (Check(dels, i))
                {
                    numb.Add(i);
                    if (i > max)
                        max = i;
                    if (i < min)
                        min = i;
                }
            }

            Console.WriteLine($"{numb.Count} {max - min}");

            static bool Check(List<int> dels, int n)
            {
                Dictionary<int, List<int>> coll = new Dictionary<int, List<int>>()
                {
                    { 0, new List<int>() },
                    { 1, new List<int>() },
                    { 2, new List<int>() },
                    { 3, new List<int>() },
                    { 4, new List<int>() },
                    { 5, new List<int>() },
                    { 6, new List<int>() },
                    { 7, new List<int>() },
                    { 8, new List<int>() },
                    { 9, new List<int>() }
                };

                for (int i = 0; i < 10; i++)
                {
                    foreach (var item in dels)
                    {
                        if (item % 10 == i)
                            coll[i].Add(item);
                    }
                }

                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < coll[i].Count; j++)
                        for (int f = j + 1; f < coll[i].Count; f++)
                            for (int k = f + 1; k < coll[i].Count; k++)
                                if (coll[i][j] * coll[i][f] * coll[i][k] == n)
                                    return true;

                Console.WriteLine(coll[2][0] * coll[3][0] * coll[5][0]);

                return false;
            }

            static List<int> IsPrime(List<int> dels)
            {
                foreach (var del in dels)
                {
                    if (del <= 1)
                        dels.Remove(del);

                    for (int d = 2; d * d <= del; d++)
                        if (del % d == 0)
                            dels.Remove(del);
                }

                return dels;
            }
        }

        internal static void Solution_128()
        {
            //4234679 10157812
            static bool Check(int x)
            {
                if (x <= 1)
                    return false;

                for (int d = 2; d * d <= x; d++)
                    if (x % d == 0)
                        return false;

                return true;
            }

            for (int i = (int)Math.Pow(4234679, 0.25); i < (int)Math.Pow(10157812, 0.25) + 1; i++)
                if (Check(i))
                    Console.WriteLine($"{(int)Math.Pow(i, 4)} {new List<int>() { i, (int)Math.Pow(i, 2), (int)Math.Pow(i, 3)}.Max()}");
        }
        
        internal static void Solution_129()
        {
            //12034679 23175821
            static bool Check(int x)
            {
                if (x <= 1)
                    return false;

                for (int d = 2; d * d <= x; d++)
                    if (x % d == 0)
                        return false;

                return true;
            }

            for (int i = (int)Math.Pow(12034679, 0.25); i < (int)Math.Pow(23175821, 0.25); i++)
                if (Check(i))
                    Console.WriteLine($"{(int)Math.Pow(i, 4)} {new List<int>() { i, (int)Math.Pow(i, 2), (int)Math.Pow(i, 3)}.Max()}");
        }
        
        internal static void Solution_130()
        {   
            //50034679 92136895
            static bool Check(int x)
            {
                if (x == 1)
                    return false;

                int d = 2;

                while (d * d <= x)
                {
                    if (x % d == 0)
                        return false;

                    d++;
                }

                return true;
            }
            

            for (int i = (int)Math.Pow(50034679, 0.25); i < (int)Math.Pow(92136895, 0.25) + 1; i++)
            {
                int x = (int)Math.Pow(i, 4);

                if (Check(i))
                    Console.WriteLine($"{x} {new List<int>() { i , (int)Math.Pow(i, 2), (int)Math.Pow(i, 3) }.Max()}");
            }
        }
        
        internal static void Solution_143()
        {
            //33333 55555
            static bool Check(int x)
            {
                if (x <= 1)
                    return false;

                for (int d = 2; d * d <= x; d++)
                    if (x % d == 0)
                        return false;

                return true;
            }

            for (int i = 33333; i < 55555; i++)
                if (Check(i) && (i.ToString().Sum(char.GetNumericValue) > 35))
                    Console.WriteLine($"{i} {i.ToString().Sum(char.GetNumericValue)}");
        }
    }
}
