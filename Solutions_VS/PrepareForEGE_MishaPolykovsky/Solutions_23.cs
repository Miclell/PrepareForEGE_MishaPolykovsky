using System;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_23
    {
        internal static void Solution_23()
        {
            int[] a = new int[31];

            for (int i = 0; i < 31; i++)
                a[i] = 0;

            a[3] = 1;

            for (int i = 3; i < 10; i++)
            {
                if (i + 1 <= 10)
                    a[i + 1] += a[i];

                if (i * 2 <= 10)
                    a[i * 2] += a[i];
            }

            for (int i = 10; i <= 30; i++)
            {
                if (i == 15)
                    a[i] = 0;

                if (i + 1 <= 30)
                    a[i + 1] += a[i];

                if (i * 2 <= 30)
                    a[i * 2] += a[i];
            }

            Console.WriteLine(a[30]);
        }
    }
}