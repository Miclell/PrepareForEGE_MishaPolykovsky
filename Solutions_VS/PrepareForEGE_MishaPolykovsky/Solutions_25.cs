using System;
using System.Collections.Generic;
using System.Linq;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_25
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_25(), use, startupOptions);

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
