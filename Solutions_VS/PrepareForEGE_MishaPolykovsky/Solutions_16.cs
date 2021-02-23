using System;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_16
    {
        internal static void Solution_18()
        {
            static int F(int n)
            {
                if (n == 1)
                    return 1;
                return 2 * F(n - 1) + G(n - 1) - 2;
            }

            static int G(int n)
            {
                if (n == 1)
                    return 1;
                return F(n - 1) + 2 * G(n - 1);
            }

            Console.WriteLine(F(14) + G(14));
        }

        internal static void Solution_40()
        {
            static int F(int n)
            {
                if (n == 1)
                    return 1;
                return F(n - 1) - n * G(n - 1);
            }

            static int G(int n)
            {
                if (n == 1)
                    return 1;
                return F(n - 1) + 2 * G(n - 1);
            }

            Console.WriteLine(G(18));
        }

        internal static void Solution_56()
        {
            static int F(int n)
            {
                if (n > 20)
                    return n * n * n + n;
                if (n % 2 == 0)
                    return 3 * F(n + 1) + F(n + 3);
                else
                    return F(n + 2) + 2 * F(n + 3);
            }

            int count = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (F(i).ToString().IndexOf('1') == -1)
                    count++;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_72()
        {
            static int F(int n)
            {
                if (n <= 70)
                    return F(n + 2) + 2 * F(3 - n);
                return n - 50;
            }

            Console.WriteLine(F(40));
        } //бесконечная рекурсия

        internal static void Solution_82()
        {
            static int F(int n)
            {
                if (n <= 5)
                    return n;
                else if (n % 4 == 0)
                    return n + F(n / 2 - 1);
                else
                    return n + F(n + 2);
            }

            for (int i = 1; i < 1000; i++)
            {
                try
                {
                    F(i);
                }
                catch
                {
                    //Console.WriteLine(i);
                }
                finally
                {
                    Console.WriteLine(i );
                }
            }
        } //бесконченая рекурсия

        internal static void Solution_83()
        {
            static int F(int n)
            {
                if (n <= 5)
                    return n;
                else if (n % 8 == 0)
                    return n + F(n / 2 - 3);
                else
                    return n + F(n + 4);
            }
            
            for (int i = 1; i < 1000; i++)
            {
                try
                {
                    F(i);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine($"{i} {e}");
                }
                finally
                {
                    Console.WriteLine(i);
                }
            }            
        } //бесконечная рекурсия

        internal static void Solution_84()
        {
            static int F(int n)
            {
                if (n < 2)
                    return n;
                if (n % 2 == 0)
                    return F(n / 2) + 1;
                else
                    return F(3 * n + 1) + 1;
            }

            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (F(i) > 100)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
