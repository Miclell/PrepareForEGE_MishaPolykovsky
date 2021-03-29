using System;
using System.Numerics;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_14
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
               ISolution.Start(new Solutions_14(), use, startupOptions);

        internal static void Solution_95()
        {
            BigInteger a = BigInteger.Pow(2, 2014) - BigInteger.Pow(4, 650) - 38;

            int count = 0;
            while (a != 0)
            {
                if (a % 2 == 1)
                    count++;

                a /= 2;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_125()
        {
            for (int x = 100; x < 1000; x++)
            {
                if ((Convert.ToString(x, 16)[0] == 'e') &&
                   (Convert.ToString(x, 8)[1] == '5') &&
                   (x % 4 == 1) &&
                   (Convert.ToString(x, 2)[^3] == '1'))
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }

        internal static void Solution_221()
        {
            BigInteger a = BigInteger.Pow(2, 5) * BigInteger.Pow(3, 25);

            int counter0 = 0, counter1 = 0, counter2 = 0;
            while (a != 0)
            {
                if (a % 3 == 0)
                    counter0++;

                if (a % 3 == 1)
                    counter1++;

                if (a % 3 == 2)
                    counter2++;

                a /= 3;
            }

            Console.WriteLine($"{counter0} {counter1} {counter2}");
        }
    }
}
