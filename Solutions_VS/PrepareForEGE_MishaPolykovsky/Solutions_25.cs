using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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

        internal static void Solution_37()
        {
            for (int i = 248015; i <= 251575; i += 2)
            {
                int d = 1, count = 0, square = 0;

                while (d * d < i)
                {
                    if (i % d == 0)
                    {
                        count += 2;

                        if (d * d == i)
                            square = d;

                        if ((i / d) * (i / d) == i)
                            square = d;
                    }

                    d++;
                }

                if (d * d == i)
                {
                    count++;

                    if (d * d == i)
                        square = d;
                }

                if (count % 2 != 0)
                    Console.WriteLine($"{i} {count} {square}");
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

        internal static void Solution_73()
        {
            int counter = 0;
            for (int i = 2; i <= 20000; i++)
            {
                int d = 2, sum = 0;

                while (d * d < i)
                {
                    if (i % d == 0)
                        sum += d + i / d;

                    d++;
                }

                if (d * d == i)
                    sum += d;

                if (sum + 1 > i)
                    counter++;
            }

            Console.WriteLine(counter);
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

        internal static void Solution_121()
        {
            static bool IsPrime(int x)
            {
                if (x <= 1)
                    return false;

                for (int d = 2; d * d <= x; d++)
                    if (x % d == 0)
                        return false;

                return true;
            }

            static bool Check(Dictionary<int, List<int>> dels, int n)
            {
                bool flag = false;
                Parallel.For(0, 10, (i, state) =>
                {
                    Parallel.For(0, dels[i].Count, a =>
                    {
                        Parallel.For(a + 1, dels[i].Count, b =>
                        {
                            Parallel.For(b + 1, dels[i].Count, c =>
                            {
                                if (dels[i][a] * dels[i][b] * dels[i][c] == n)
                                    flag = true;

                                if (flag)
                                    state.Break();
                            });
                        });
                    });
                });

                if (flag)
                    return true;

                return false;
            }

            int count = 0, min = 369454;
            Parallel.For(318216, 369453, i =>
            {
                Dictionary<int, List<int>> dels = Enumerable.Range(0, 10).ToDictionary(x => x, x => new List<int>());

                Parallel.For(1, i, (d, state) =>
                {
                    if (d * d >= i)
                        state.Break();

                    if (i % d == 0)
                    {
                        if (IsPrime(d))
                            dels[d % 10].Add(d);

                        if (IsPrime(i / d))
                            dels[i / d % 10].Add(i / d);
                    }                    

                    d++;
                });

                if (Check(dels, i))
                {
                    min = Math.Min(i, min);
                    count++;
                }
            });

            Console.WriteLine($"{min} {count}");
        }

        internal static void Solution_123()
        {
            //416782; 498324
            int max = 0, min = 498325, count = 0;
            for (int i = 416782; i <= 498324; i++)
            {
                List<int> dels = new List<int>();

                int k = 0, d;
                for (d = 2; d * d < i; d++)
                {
                    if (i % d == 0)
                    {
                        k += 2;
                        if (IsPrime(d))
                            dels.Add(d);
                        if (IsPrime(i / d))
                            dels.Add(i / d);
                    }

                    if (k > 6)
                        break;
                }

                if (d * d == i)
                    k++;

                if ((k == 6) && (dels.Count == 3) &&
                    (dels[0] % 10 == dels[1] % 10) &&
                    (dels[1] % 10 == dels[2] % 10))
                {
                    count++;
                    if (i > max)
                        max = i;
                    if (i < min)
                        min = i;
                }
            }

            Console.WriteLine($"{count} {max - min}");

            static bool IsPrime(int n)
            {
                for (int d = 2; d * d <= n; d++)
                    if (n % d == 0)
                        return false;

                return true;
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
                    Console.WriteLine($"{(int)Math.Pow(i, 4)} {new List<int>() { i, (int)Math.Pow(i, 2), (int)Math.Pow(i, 3) }.Max()}");
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
                    Console.WriteLine($"{(int)Math.Pow(i, 4)} {new List<int>() { i, (int)Math.Pow(i, 2), (int)Math.Pow(i, 3) }.Max()}");
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
                    Console.WriteLine($"{x} {new List<int>() { i, (int)Math.Pow(i, 2), (int)Math.Pow(i, 3) }.Max()}");
            }
        }

        internal static void Solution_138()
        {
            //1000000; 1500000
            for (int i = 1000000; i <= 1500000; i++)
            {
                int d, count = 0, max = 0; ;

                for (d = 1; d * d < i; d++)
                {
                    if (i % d == 0)
                        if (i / d - d <= 110)
                        {
                            count++;

                            if (i / d > max)
                                max = i / d;
                        }

                    if (count == 3)
                        break;
                }

                if (d * d == i)
                    count++;

                if (count >= 3)
                    Console.WriteLine($"{i} {max}");
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

        internal static void Solution_144()
        {
            //33333;55555
            for (int i = 33333; i <= 55555; i++)
            {
                List<int> dels = new List<int>();

                int d;
                for (d = 2; d * d < i; d++)
                {
                    if (i % d == 0)
                    {
                        if (IsPrime(d))
                            dels.Add(d);
                        if (IsPrime(i / d))
                            dels.Add(i / d);
                    }

                    if ((dels.Sum(x => x) >= 250) && (i % dels.Sum(x => x) == 0))
                        break;
                }

                if ((d * d == i) && IsPrime(d * d))
                    dels.Add(d);

                if ((dels.Sum(x => x) >= 250) && (i % dels.Sum(x => x) == 0))
                    Console.WriteLine($"{i} {dels.Sum(x => x)}");
            }

            static bool IsPrime(int n)
            {
                for (int d = 2; d * d <= n; d++)
                    if (n % d == 0)
                        return false;

                return true;
            }
        }

        internal static void Solution_160()
        {
            static bool IsPrime(int x)
            {
                if (x <= 1)
                    return false;

                for (int d = 2; d * d <= x; d++)
                    if (x % d == 0)
                        return false;

                return true;
            }

            int count = 0;
            for (int i = 10000000; count != 3; i--)
                if (IsPrime(i))
                {
                    Console.WriteLine($"{10000000 - i} {i}");
                    count++;
                }

            count = 0;
            for (int i = 10000000; count != 3; i++)
                if (IsPrime(i))
                {
                    Console.WriteLine($"{i - 10000000} {i}");
                    count++;
                }
        }
    }
}
