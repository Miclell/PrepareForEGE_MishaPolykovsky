﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_8
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_8(), use, startupOptions);

        internal static void Solution_7()
        {
            //АКРУ
            string[] table = new[] { "0", "1", "2", "3" };

            List<string> res = new List<string>();

            while (res.Count < 350)
                res.AddRange(from item in table
                             from item1 in table
                             from item2 in table
                             from item3 in table
                             from item4 in table
                             select $"{item}{item1}{item2}{item3}{item4}");

            Console.WriteLine(res[349]);
        }

        internal static void Solution_10()
        {
            //10101
            string[] table = new[] { "0", "1", "2" };

            List<string> res = new List<string>();

            while (res.Count <= 1000)
                res.AddRange(from item in table
                             from item1 in table
                             from item2 in table
                             from item3 in table
                             from item4 in table
                             select $"{item}{item1}{item2}{item3}{item4}");

            Console.WriteLine(res.IndexOf("10101") + 1);
        }

        internal static void Solution_21()
        {
            //0123
            string[] table = new[] { "0", "1", "2", "3" };

            List<string> res = (from item in table
                                from item1 in table
                                from item2 in table
                                from item3 in table
                                select $"{item}{item1}{item2}{item3}").ToList();

            for (int i = 0; i < res.Count; i++)
                if (res[i][0] == '1' || res[i][0] == '3')
                {
                    res.Remove(res[i]);
                    i--;
                }

            Console.WriteLine(res.Count);
        }

        internal static void Solution_28() =>
            Console.WriteLine((from item in new[] { "0", "1", "2", "3", "4" }
                               from item1 in new[] { "0", "1", "2", "3", "4" }
                               from item2 in new[] { "0", "1", "2", "3", "4" }
                               from item3 in new[] { "0", "1", "2", "3", "4" }
                               from item4 in new[] { "0", "1", "2", "3", "4" }
                               select $"{item}{item1}{item2}{item3}{item4}")
                               .Distinct()
                                   .Where(item => item.Count(x => x == '0') == 2)
                                       .Count());

        internal static void Solution_31() =>
            Console.WriteLine((from item in new[] { "0", "1", "2", "3", "4" }
                               from item1 in new[] { "0", "1", "2", "3", "4" }
                               from item2 in new[] { "0", "1", "2", "3", "4" }
                               from item3 in new[] { "0", "1", "2", "3", "4" }
                               select $"{item}{item1}{item2}{item3}")
                               .Distinct()
                                   .Where(item => (item[0] == '1' || item[0] == '4') &&
                                                  (item[3] == '0' || item[3] == '2' || item[3] == '3'))
                                       .Count());
        
        internal static void Solution_32() =>
            Console.WriteLine((from item in new[] { "0", "1", "2", "3" }
                               from item1 in new[] { "0", "1", "2", "3" }
                               from item2 in new[] { "0", "1", "2", "3" }
                               select $"{item}{item1}{item2}")
                               .Distinct()
                                   .Where(item => item.IndexOf("0") != -1 ?
                                                  item.IndexOf("0") == 0 ? item.IndexOf("0") + 1 == item.IndexOf("3") :
                                                  item.IndexOf("0") == 2 ? item.IndexOf("0") - 1 == item.IndexOf("3") :
                                                  item.IndexOf("0") + 1 == item.IndexOf("3") ||
                                                  item.IndexOf("0") - 1 == item.IndexOf("3") :
                                                  item.IndexOf("1") == 1 || item.IndexOf("2") == 1 || (item.IndexOf("1") == 0 ?
                                                  item.IndexOf("1") + 1 != item.IndexOf("2") :
                                                  item.IndexOf("1") == 2 && item.IndexOf("1") - 1 != item.IndexOf("2"))
                                                  )
                                       .Count() - 4); //где-то тут в условии ошибка :(

        internal static void Solution_117()
        {
            Console.WriteLine((from item in new[] { "0", "1", "2", "3", "3", "3" }
                               from item1 in new[] { "0", "1", "2", "3", "3", "3" }
                               from item2 in new[] { "0", "1", "2", "3", "3", "3" }
                               from item3 in new[] { "0", "1", "2", "3", "3", "3" }
                               from item4 in new[] { "0", "1", "2", "3", "3", "3" }
                               from item5 in new[] { "0", "1", "2", "3", "3", "3" }
                               select $"{item}{item1}{item2}{item3}{item4}{item5}")
                               .Distinct()
                                   .Where(item => Check_117(item))
                                       .Count());

            static bool Check_117(string item)
            {
                if ((item.Count(x => x == '1') == 1) &&
                    (item.Count(x => x == '2') == 1) &&
                    (item.Count(x => x == '0') == 1) &&
                    (item.Count(x => x == '3') == 3))
                {
                    for (int i = 0; i < item.Length - 1; i++)
                        if ((item[i] == '3') && (item[i + 1] == '3'))
                            return false;

                    return true;
                }

                return false;
            }
        }

        internal static void Solution_184()
        {
            string[] table = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            List<string> lst = new();
            Parallel.ForEach(table, item =>
            {
                Parallel.ForEach(table, item1 =>
                {
                    Parallel.ForEach(table, item2 =>
                    {
                        Parallel.ForEach(table, item3 =>
                        {
                            Parallel.ForEach(table, item4 =>
                            {
                                Parallel.ForEach(table, item5 =>
                                {
                                    Parallel.ForEach(table, item6 =>
                                    {
                                        Parallel.ForEach(table, item7 =>
                                        {
                                            Parallel.ForEach(table, item8 =>
                                            {
                                                Parallel.ForEach(table, item9 =>
                                                {
                                                    Parallel.ForEach(table, item10 =>
                                                    {
                                                        Parallel.ForEach(table, item11 =>
                                                        {
                                                            lst.Add($"{item}{item1}{item2}{item3}{item4}{item5}{item6}{item7}{item8}{item9}{item10}{item11}");
                                                        });
                                                    });
                                                });
                                            });
                                        });
                                    });
                                });
                            });
                        });
                    });
                });
            });

            int count = 0;
            foreach (var item in lst)
            {
                int counter = 0;
                for (int i = 0; i < 11; i++)
                {
                    if ((item[i] > item[i + 1]) &&
                        (item[i] % 2 != 0 && item[i + 1] % 2 == 0 ||
                        item[i] % 2 == 0 && item[i + 1] % 2 != 0))
                        counter++;
                }

                if (counter == 11)
                    count++;
            }

            Console.WriteLine(count);
        }

        internal static void Solution_185()
        {
            string[] table = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            List<string> lst = new();
            foreach (var item in table)
                foreach (var item1 in table)
                    foreach (var item2 in table)
                        foreach (var item3 in table)
                            foreach (var item4 in table)
                                foreach (var item5 in table)
                                    lst.Add($"{item}{item1}{item2}{item3}{item4}{item5}");

            int count = 0;
            foreach (var item in lst)
            {
                int counter = 0; 
                for (int i = 0; i < 5; i++)
                {
                    if ((item[i] > item[i + 1]) &&
                        (item[i] % 2 != 0 && item[i + 1] % 2 == 0 ||
                        item[i] % 2 == 0 && item[i + 1] % 2 != 0))
                        counter++;
                }

                if (counter == 5)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
