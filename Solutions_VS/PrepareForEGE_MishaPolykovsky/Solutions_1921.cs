using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_1921
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_1921(), use, startupOptions);

        internal static void Solution_86()
        {
            //(3, 5) -> (8, 5) | (3, 8)

            static int GetWinner(int a, int b, int n)
            {
                if (Math.Max(a + b * 2, 2 * a + b) >= 45)
                    return n + 1;

                if (a + b * 2 > a * 2 + b)
                    return GetWinner(a + b, b, n + 1);
                else
                    return GetWinner(a, b + a, n + 1);
            }

            static bool GetWinner_20(int a, int b)
            {
                Dictionary<string, bool> keyValuePairs = new();

                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 2; j++)
                        for (int f = 0; f < 2; f++)
                        {
                            Tuple<int, int> valuePair = new(a, b);

                            if (i == 0)
                            {
                                valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                if (valuePair.Item1 + valuePair.Item2 >= 45)
                                {
                                    keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    continue;
                                }

                                if (j == 0)
                                {
                                    valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                    if (valuePair.Item1 + valuePair.Item2 >= 45)
                                    {
                                        keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                        continue;
                                    }

                                    if (b == 13)
                                        Console.WriteLine(valuePair.Item1 + " " + valuePair.Item2 + $" {i} {j} {f}");

                                    if (f == 0)
                                    {
                                        valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                    else
                                    {
                                        valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                }
                                else
                                {
                                    valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                    if (valuePair.Item1 + valuePair.Item2 >= 45)
                                    {
                                        keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                        continue;
                                    }

                                    if (f == 0)
                                    {
                                        valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                    else
                                    {
                                        valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                }
                            }
                            else
                            {
                                valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                if (valuePair.Item1 + valuePair.Item2 >= 45)
                                {
                                    keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    continue;
                                }

                                if (j == 0)
                                {
                                    valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                    if (valuePair.Item1 + valuePair.Item2 >= 45)
                                    {
                                        keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                        continue;
                                    }

                                    if (f == 0)
                                    {
                                        valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                    else
                                    {
                                        valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                }
                                else
                                {
                                    valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                    if (valuePair.Item1 + valuePair.Item2 >= 45)
                                    {
                                        keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                        continue;
                                    }

                                    if (f == 0)
                                    {
                                        valuePair = new(valuePair.Item1 + valuePair.Item2, valuePair.Item2);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                    else
                                    {
                                        valuePair = new(valuePair.Item1, valuePair.Item2 + valuePair.Item1);

                                        if (valuePair.Item1 + valuePair.Item2 >= 45)
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), true);
                                        else
                                            keyValuePairs.Add(i.ToString() + j.ToString() + f.ToString(), false);
                                    }
                                }
                            }
                        }

                if ((keyValuePairs["000"] || keyValuePairs["001"]) && (keyValuePairs["010"] || keyValuePairs["011"]) ||
                    (keyValuePairs["100"] || keyValuePairs["101"]) && (keyValuePairs["110"] || keyValuePairs["111"]))
                    return true;

                return false;
            }

            //19
            for (int i = 1; i < 38; i++)
                if (GetWinner(7, i, 0) == 2)
                {
                    Console.WriteLine(i + "\n");
                    break;
                }

            //20
            for (int i = 39; i > 1; i--)
                if (GetWinner_20(6, i))
                {
                    Console.WriteLine(i + "\n");
                    break;
                }

            for (int i = 1; i < 39; i++)
                if (GetWinner_20(6, i))
                {
                    Console.WriteLine(i + "\n");
                    break;
                }

            //21
            for (int i = 1; i < 45; i++)
                if (GetWinner(i, i, 0) == 4)
                {
                    Console.WriteLine(i);
                    break;
                }
        }
    }
}
