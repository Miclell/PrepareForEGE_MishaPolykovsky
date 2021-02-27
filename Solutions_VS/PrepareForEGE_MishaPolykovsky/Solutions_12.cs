using System;
using System.Collections.Generic;
using System.Text;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_12
    {
        internal static void Solution_78()
        {
            static bool Check(int i, int j, int goI, int goJ)
            {
                if (((i == 4) && (j == 1) && (goI == 4) && (goJ == 2)) ||
                    ((i == 4) && (j == 2) && (goI == 4) && (goJ == 1)) ||
                    ((i == 4) && (j == 2) && (goI == 3) && (goJ == 2)) ||
                    ((i == 3) && (j == 2) && (goI == 4) && (goJ == 2)) ||
                    ((i == 1) && (j == 2) && (goI == 1) && (goJ == 3)) ||
                    ((i == 1) && (j == 3) && (goI == 1) && (goJ == 2)) ||
                    ((i == 6) && (j == 3) && (goI == 5) && (goJ == 3)) ||
                    ((i == 5) && (j == 3) && (goI == 6) && (goJ == 3)) ||
                    ((i == 5) && (j == 3) && (goI == 5) && (goJ == 4)) ||
                    ((i == 5) && (j == 4) && (goI == 5) && (goJ == 3)) ||
                    ((i == 4) && (j == 3) && (goI == 4) && (goJ == 4)) ||
                    ((i == 4) && (j == 4) && (goI == 4) && (goJ == 3)) ||
                    ((i == 4) && (j == 4) && (goI == 3) && (goJ == 4)) ||
                    ((i == 3) && (j == 4) && (goI == 4) && (goJ == 4)) ||
                    ((i == 3) && (j == 4) && (goI == 3) && (goJ == 5)) ||
                    ((i == 3) && (j == 5) && (goI == 3) && (goJ == 4)) ||
                    ((i == 2) && (j == 4) && (goI == 2) && (goJ == 5)) ||
                    ((i == 2) && (j == 5) && (goI == 2) && (goJ == 4)) ||
                    ((i == 5) && (j == 5) && (goI == 5) && (goJ == 6)) ||
                    ((i == 5) && (j == 6) && (goI == 5) && (goJ == 5)) ||
                    ((i == 4) && (j == 5) && (goI == 4) && (goJ == 6)) ||
                    ((i == 4) && (j == 6) && (goI == 4) && (goJ == 5)) ||
                    ((i == 1) && (j == 6) && (goI == 2) && (goJ == 6)) ||
                    ((i == 2) && (j == 6) && (goI == 1) && (goJ == 6)) ||
                    ((i == 1) && (j == 6) && (goI == 1) && (goJ == 7)) ||
                    ((i == 2) && (j == 6) && (goI == 2) && (goJ == 7)) ||
                    ((i == 3) && (j == 6) && (goI == 3) && (goJ == 7)) ||
                    ((i == 4) && (j == 6) && (goI == 4) && (goJ == 7)) ||
                    ((i == 5) && (j == 6) && (goI == 5) && (goJ == 7)) ||
                    ((i == 6) && (j == 6) && (goI == 6) && (goJ == 7)) ||
                    ((i == 6) && (j == 1) && (goI == 7) && (goJ == 1)) ||
                    ((i == 6) && (j == 2) && (goI == 7) && (goJ == 2)) ||
                    ((i == 6) && (j == 3) && (goI == 7) && (goJ == 3)) ||
                    ((i == 6) && (j == 4) && (goI == 7) && (goJ == 4)) ||
                    ((i == 6) && (j == 5) && (goI == 7) && (goJ == 5)) ||
                    ((i == 6) && (j == 6) && (goI == 7) && (goJ == 6))
                    )
                    return false;

                return true;
            }

            int[] lastPoz = new int[2];

            int count = 0;
            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                {
                    lastPoz[0] = i;
                    lastPoz[1] = j;

                    bool flag = true;

                    while ((Check(lastPoz[0], lastPoz[1], lastPoz[0], lastPoz[1] + 1) || Check(lastPoz[0], lastPoz[1], lastPoz[0] + 1, lastPoz[1])) && flag)
                    {
                        while ((Check(lastPoz[0], lastPoz[1], lastPoz[0], lastPoz[1] + 1)) && flag)
                            if ((Check(lastPoz[0], lastPoz[1], lastPoz[0], lastPoz[1] + 1)) && flag)
                                lastPoz[1] += 1;
                            else
                            {
                                flag = false;
                                break;
                            }

                        if (Check(lastPoz[0], lastPoz[1], lastPoz[0] + 1, lastPoz[1]) && flag)
                            lastPoz[0] += 1;
                        else
                        {
                            flag = false;
                            break;
                        }
                    }

                    if ((lastPoz[0] == 6) && (lastPoz[1] == 6) && flag)
                        count++;
                }

            Console.WriteLine(count);
        }
    }
}
