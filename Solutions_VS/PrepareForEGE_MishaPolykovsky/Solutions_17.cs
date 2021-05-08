using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_17
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_17(), use, startupOptions);

        internal static void Solution_30()
        {
            int min = Int32.MaxValue, sum = 0;
            for (int i = 1529; i <= 9482; i++)
                if (i % 2 == 1 && i / 2 % 2 == 0 && i % 5 == 3)
                {
                    min = Math.Min(min, i);
                    sum += i;
                }

            Console.WriteLine($"{min} {sum}");
        }

        internal static void Solution_31()
        {
            int min = Int32.MaxValue, count = 0;
            for (int i = 1000; i <= 9999; i++)
            {
                int a = i;
                string five = "";
                while (a != 0)
                {
                    five += a % 5;

                    a /= 5;
                }

                if (five.Length >= 6 && five[1] == '2' && "13".Contains(five[0]))
                {
                    min = Math.Min(i, min);

                    count++;
                }
            }

            Console.WriteLine($"{count} {min}");
        }

        internal static void Soluiton_33()
        {
            int max = 0, min = Int32.MaxValue;
            for (int i = 1000; i <= 9999; i++)
            {
                int a = i;
                if (i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
                {
                    int count = 0;
                    while (a != 0)
                    {
                        count++;

                        a /= 3;
                    }

                    if (count == 8)
                    {
                        max = i;

                        min = Math.Min(min, i);
                    }
                }
            }

            Console.WriteLine($"{min} {max}");
        }

        internal static void Solution_36()
        {
            int count = 0, min = 7858, max = 0;
            for (int i = 2476; i <= 7857; i++)
            {
                if (i % 2 == 0 && i % 8 != 0 && i / 100 % 10 <= 7)
                {
                    max = i;
                    count++;
                    min = Math.Min(i, min);
                }
            }

            Console.WriteLine($"{count} {(max + min) / 2}");
        }

        internal static void Solution_37()
        {
            int count = 0, min = 7999;
            for (int i = 3905; i <= 7998; i++)
                if (!"05".Contains((i / 10 % 10).ToString()) && Enumerable.Range(2, 5).Contains(i / 100 % 10))
                //if (i / 10 % 10 != 5 && i / 10 % 10 != 0 && i / 100 % 10 >= 2 && i / 100 % 10 <= 6)
                {
                    count++;

                    min = Math.Min(i, min);
                }

            Console.WriteLine($"{count} {min}");
        }

        internal static void Solution_119()
        {
            int count = 0, max = 0;
            for (int i = 2827; i <= 18186; i++)
            {
                if (i % 16 == 15 && i / 16 % 16 != 1 && i % 11 == 0)
                {
                    count++;
                    max = i;
                }
            }

            Console.WriteLine($"{count} {max * max}");
        }
    }
}
