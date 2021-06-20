using System;
using System.Linq;
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

        internal static void Solution_265()
        {
            int sum = 0;
            for (int i = 2; i <= 10; i++)
            {
                int t = 1755;
                string s = "";

                if (i != 10)
                    while (t != 0)
                    {
                        s += (t % i).ToString();

                        t /= i;
                    }
                else
                    s = String.Join("", t.ToString().Reverse());

                bool flag = true;
                for (int j = 0; j < 10; j++)
                    if (s.Count(x => x == Convert.ToChar(j.ToString())) > 1)
                        flag = false;

                if (flag)
                    sum += i;
            }

            Console.WriteLine(sum);
        }

        internal static void Solution_283()
        {
            int sum = 0;
            for (int i = 2; i <= 10; i++)
            {
                int t = 123;
                string s = "";

                if (i != 10)
                    while (t != 0)
                    {
                        s += (t % i).ToString();

                        t /= i;
                    }
                else
                    s = String.Join("", t.ToString().Reverse());

                bool flag = true, flagArithmetiсProgress = true;
                int d = 0;
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j] <= s[j + 1])
                        flag = false;

                    if (flagArithmetiсProgress)
                    {
                        d = int.Parse(s[j + 1].ToString()) - int.Parse(s[j].ToString());
                        flagArithmetiсProgress = false;
                    }
                    else if (d != int.Parse(s[j + 1].ToString()) - int.Parse(s[j].ToString()))
                        flag = false;
                }

                if (flag)
                    sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
