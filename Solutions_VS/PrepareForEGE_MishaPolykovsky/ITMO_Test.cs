using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class ITMO_Test
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new ITMO_Test(), use, startupOptions);

        internal static void Solution_1()
        {
            bool[] table = new[] { false, true };

            foreach (var x in table) foreach (var y in table)
                    foreach (var z in table)
                        foreach (var w in table)
                            if (((!(x == !y) || (y && !z)) || (z && !w)) == false)
                                Console.WriteLine($"{Convert.ToInt32(w)} {Convert.ToInt32(z)} {Convert.ToInt32(x)} {Convert.ToInt32(y)}");
        }
        
        internal static void Solution_5()
        {
            static int F(int n)
            {
                int res = 0;

                if (n > 3)
                    res += n;
                else
                {
                    res += F(n - 3);
                    res += F(n - 4);
                }

                return res;
            }

            Console.WriteLine(F(28));
        }
       
        internal static void Solution_7()
        {
            //3435 + 73 – 1 – X

            for (BigInteger i = 1; i < 1000; i++)
            {
                BigInteger res = BigInteger.Pow(343, 5) + BigInteger.Pow(7, 3) - 1 - i;

                int count = 0;
                while (res != 0)
                {
                    if (res % 7 == 6)
                        count++;

                    res /= 7;
                }

                if (count == 12)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
       
        internal static void Solution_8()
        {
            //((X & 20 = 0) ® (X & 52 ¹ 0)) ® (X & A ¹ 0)

            for (int a = 1; a < 10000; a++)
            {
                bool flag = true;
                for (int x = 1; x < 1000; x++)
                    if (((((x & 20) == 0) && ((x & 52) != 0)) || ((x & a) != 0)) == false)
                        flag = false;

                if (flag)
                {
                    Console.WriteLine(a);
                    break;
                }
            }
        }
      
        internal static void Solution_9()
        {
            for (int i = 101; i < 1000; i++)
            {
                int x = i, l = x, m = 64;

                if (l % 2 == 0)
                    m = 45;

                while (l != m)
                {
                    if (l > m)
                        l -= m;
                    else
                        m -= l;
                }

                if (m == 15)
                    Console.WriteLine(i);
            }
        }
        
        internal static void Solution_11()
        {
            //101 000 000; 102 000 000

            for (int i = 101000000; i < 102000000; i++)
            {
                int d, count = 0;

                for (d = 1; d * d < i; d++)
                {
                    if (i % d == 0)
                    {
                        if (d % 2 == 0)
                            count++;

                        if (i / d % 2 == 0)
                            count++;
                    }
                }

                if ((d * d == i) && (d * d % 2 == 0))
                    count++;

                if (count == 3)
                    Console.WriteLine(i);
            }
        }
    }
}
