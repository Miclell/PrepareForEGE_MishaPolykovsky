using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Numerics;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_StatGrad_B1_2210
    {
        internal static void Solution_2()
        {
            //(w \/ ¬x) /\ (w ≡ ¬y) /\ (w → z)

            bool[] table = new[] { false, true };
            foreach (var x in table)
                foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if ((w || !x) && (w == !y) && (!w || z))
                                Console.WriteLine($"{Convert.ToInt32(w)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(x)}");
        }

        internal static void Solution_4()
        {
            //128
            int i;
            for (i = 0; i < 1000; i++)
            {
                int s = i, n = 4;
                while (s < 37)
                {
                    s += 3;
                    n *= 2;
                }

                if (n == 128)
                    goto Finsish;
            }
        Finsish:
            Console.WriteLine(i);
        }

        internal static void Solution_12()
        {
            string s = string.Join("", Enumerable.Repeat("1", 99));

            while (s.Contains("111"))
            {
                s = s.Replace("111", "22");
                s = s.Replace("222", "11");
            }

            Console.WriteLine(s);
        }

        internal static void Solution_14()
        {
            BigInteger a = BigInteger.Pow(81, 17) + BigInteger.Pow(3, 24) - 45;

            int count = 0;
            while (a != 0)
            {
                if (a % 9 == 8)
                    count++;

                a /= 9;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_15()
        {
            //(A < 50) /\ (¬ДЕЛ(x, A) → (ДЕЛ(x, 10) → ¬ДЕЛ(x, 12)))


            for (int a = 1000; a > 0; a--)
            {
                bool flag = true;
                for (int x = 0; x < 1000; x++)
                {
                    if (((a < 50) && ((x % a == 0) || (x % 10 != 0) || (x % 12 != 0))) == false)
                        flag= false;
                }

                if (flag)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }

        internal static void Solution_16()
        {
            //F(1) = 1;
            //F(n) = n + F(n–2), если n > 1 и при этом n нечётно;
            //F(n) = n × F(n–1), если n чётно

            static int F(int n)
            {
                if (n == 1)
                    return 1;

                if (n % 2 != 0)
                    return n + F(n - 2);

                return n * F(n - 1);
            }

            Console.WriteLine(F(60));
        }

        internal static void Solution_17()
        {
            static int Count(BigInteger first, BigInteger last)
            {
                int count = 0;
                for (BigInteger i = first; i < last; i++)
                    if ((i % 7 == 0) && (i % 100000 == 0) &&
                        (i % 13 != 0) && (i % 29 != 0) &&
                        (i % 43 != 0) && (i % 101 != 0))
                        count++;

                return count;
            }

            int count = 0;
            BigInteger h = (4 * BigInteger.Pow(10, 10) - 2 * BigInteger.Pow(10, 10)) / 60, f = 2 * BigInteger.Pow(10, 10); ;
            Enumerable.Range(0, 60).AsParallel().ForAll(x =>
            {
                count += Count(f, f + h);
                f += h;
            });

            Console.WriteLine($"{count} ого"); // 2055, 5 минут и готово)))
        } //страшилка, но вроде работает :)

        internal static void Solution_22()
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = i, a = 1;
                while (x > 0)
                {
                    a *= x % 7;
                    x /= 7;
                }

                if (a == 48)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
