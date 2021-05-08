using System;
using System.Linq;
using System.Collections.Generic;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_15
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_15(), use, startupOptions);

        internal static void Solution_120()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x % a == 0) || (x % 6 != 0)) || (x % 3 != 0)) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_123()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if (((x % 18 != 0) || ((x % a == 0) || (x % 12 != 0))) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_133()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x % 40 != 0) && (x % 64 != 0)) || (x % a == 0)) == false)
                            flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_141()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x % a != 0) || (x % 50 == 0)) || ((x % 18 != 0) || (x % 50 == 0))) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_144()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((!((x % a == 0) && (x % 24 == 0) && (x % 16 != 0)) || (x % a != 0)) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_146()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {                    
                    if ((((x % 15 != 0) || (x % 21 == 0)) || ((x % a != 0) || (x % 15 != 0))) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }        

        internal static void Solution_151()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x & 35) == 0) || ((x & 31) != 0) || ((x & a) != 0)) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_160()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x & 25) == 0) ||
                        (((x & 17) != 0) ||
                        ((x & a) != 0))) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_163()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x & 13) == 0) ||
                        ((x & 39) == 0) || 
                        ((x & a) != 0) &&
                        ((x & 13) != 0)) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_164()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((
                            (
                                (
                                    (x & 13) == 0) &&
                                    ((x & 39) != 0)
                                ) ||
                            ((x & 13) != 0) ||
                            (
                                    ((x & a) == 0) &&
                                    ((x & 13) == 0)
                            )
                        ) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_169()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((
                            (
                                ((x & 20) == 0) &&
                                ((x & 55) == 0)
                            ) ||                                
                            ((x & 7) != 0) ||
                            ((x & a) != 0)                            
                        ) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_178()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((
                            (
                                ((x & 19) == 0) &&
                                ((x & 38) != 0)
                            ) ||
                            ((x & 43) != 0) ||
                            (
                                ((x & a) == 0) &&
                                ((x & 43) == 0)
                            )
                        ) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_179()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((
                            (
                                ((x & 19) == 0) &&
                                ((x & 38) != 0)
                            ) ||
                            ((x & 43) != 0) ||
                            (
                                ((x & a) == 0) &&
                                ((x & 43) == 0)
                            )
                        ) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_180()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    if ((((x & a) == 0) || 
                        (((x & 17) != 0) || ((x & 5) != 0)) ||
                        ((x & 3) != 0)) == false)
                        flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_239()
        {
            int min = 2000;
            for (int aStart = 100; aStart < 200; aStart++)
                for (int aEnd = aStart + 1; aEnd < 200; aEnd++)
                {
                    bool flag = true;
                    for (double x = 1; x < 1000; x += 0.1)
                    {
                        if ((x < 155 || x > 177 ||
                             x <= 130 && x >= 111 ||
                             x <= aEnd && x >= aStart) == false)
                            flag = false;
                    }

                    if (flag)
                        min = Math.Min(aEnd - aStart, min);
                }

            Console.WriteLine(min);
        }

        internal static void Solution_282()
        {
            int max = 0;
            for (int aStart = -1000; aStart < 1000; aStart++)
                for (int aEnd = aStart + 1; aEnd < 1000; aEnd++)
                {
                    bool flag = true;
                    for (double x = -100; x < 100; x += 0.1)
                        if (((x > aEnd || x < aStart || x * x + 10 * x <= 144) &&
                             (x * x + 6 * x > 112 || x <= aEnd && x >= aStart)) == false)
                            flag = false;

                    if (flag)
                        max = Math.Max(Math.Abs(aEnd - aStart), max);
                }

            Console.WriteLine(max);
        }

        internal static void Solution_296()
        {
            int a;
            for (a = 1; a < 1000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                {
                    for (int y = 1; y < 1000; y++)
                        if (((2 * y + 5 * x < a) || (2 * x + 4 * y > 100) || (3 * x - 2 * y > 70)) == false)
                            flag = false;
                }

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_304()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                    for (int y = 1; y < 1000; y++)
                        if (((4 * y - x > a) || (x + 6 * y < 210) || (3 * y - 2 * x < 30)) == false)
                            flag = false;
                if (flag)
                 break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_308()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                    for (int y = 1; y < 1000; y++)
                        if (((y + 3 * x != 60) || (2 * x > a) || (y > a)) == false)
                            flag = false;

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Solution_328()
        {
            int a;
            //DateTime time = new DateTime();
            //bool[] superflag = { false, false };
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 100; x++)
                    for (int y = 1; y < 100; y++)
                        for (int z = 1; z < 100; z++)
                            if (((y + 2 * x + z != 220) || (a < 6 * x) || (a < y) || (a < 2 * z)) == false)
                                flag = false;

                //if (!superflag[0])
                //{
                //    time = DateTime.Now;
                //    superflag[0] = true;
                //}
                //else if (!superflag[1])
                //{
                //    Console.WriteLine(DateTime.Now - time);
                //    Console.WriteLine((DateTime.Now - time) * 1000);
                //    superflag[1] = true;                    
                //}

                if (flag)
                    break;                
            }

            Console.WriteLine(a);
        }

        internal static void Solution_329()
        {
            int a;
            for (a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 1; x < 100; x++)
                    for (int y = 1; y < 100; y++)
                        for (int z = 1; z < 100; z++)
                            if (((x + 3 * y + 2 * z - 54 != 0) || (a < x + 10) || (a < 5 * y - 4 * x) || (a < z + x)) == false)
                                flag = false;

                if (flag)
                    break;
            }

            Console.WriteLine(a);
        }

        internal static void Soluiton_376()
        {
            int min = Int32.MaxValue;
            for (int aStart = -100; aStart < 100; aStart++)
            {
                for (int aEnd = -100; aEnd < 100; aEnd++)
                {
                    bool flag = true;

                    for (int x = -100; x < 100; x++)
                    {
                        if (((new List<int>() { 2, 4, 9, 10, 15 }.Contains(x) == (x <= aEnd && x >= aStart)) ||
                            (new List<int>() { 3, 8, 9, 10, 20 }.Contains(x) == (x <= aEnd && x >= aStart))) == false)
                            flag = false;
                    }

                    if (flag)
                        min = Math.Min(Enumerable.Range(aStart, aEnd - aStart + 1).Aggregate((x, y) => x * y), min);
                }
            }

            Console.WriteLine(min);
        }
    }
}