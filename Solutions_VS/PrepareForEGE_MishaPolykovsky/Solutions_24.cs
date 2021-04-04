using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_24
    {
        internal static void Start(int region, object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include)
        {
            switch (region)
            {
                case 1:
                    ISolution.Start(new SolutionsForDefolt(), use, startupOptions);
                    break;
                case 2:
                    ISolution.Start(new SolutionsForLinq(), use, startupOptions);
                    break;
                case 3:
                    ISolution.Start(new SolutionsForRegex(), use, startupOptions);
                    break;
            }
        }

        internal class SolutionsForDefolt
        {
            internal virtual void Solution_7()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7-40.txt");

                int count = 0, max = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'C')
                        count++;
                    else
                    {
                        max = Math.Max(count, max);
                        count = 0;
                    }
                }

                Console.WriteLine(max);
            }

            internal virtual void Solution_22() =>
                throw new NotImplementedException();

            internal virtual void Solution_25()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7a-5.txt");

                int count = 0, max = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != 'C' && s[i] != 'F')
                    {
                        count++;
                    }
                    else
                    {
                        max = Math.Max(max, count);
                        count = 0;
                    }
                }

                Console.WriteLine(max);
            }

            internal virtual void Solution_36()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7c-4.txt");

                int count = 0;
                for (int i = 0; i < s.Length - 2; i++)
                {
                    if ("ADF".Contains(s[i]) &&
                        "CDF".Contains(s[i + 1]) &&
                        "CDF".Contains(s[i + 2]) &&
                        s[i] != s[i + 2] &&
                        s[i + 1] != s[i + 2])
                        count++;
                }

                Console.WriteLine(count);
            }

            internal virtual void Solution_51()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7-m26.txt");

                int count = 0, index = -1;
                for (int i = 0; i < s.Length - 2; i++)
                    if (s[i + 1] < s[i] && s[i + 1] < s[i + 2])
                    {
                        count++;
                        index = i;
                    }

                Console.WriteLine($"{count} {index}");
            }

            internal virtual void Solution_52() =>
                throw new NotImplementedException();

            internal virtual void Solution_62() =>
                throw new NotImplementedException();

            internal virtual void Solution_75()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k8data\k8-12.txt");

                int max = 0, k = 1;
                for (int i = 1; i < s.Length; i++)
                    if (s[i] == s[i - 1])
                    {
                        k += 1;
                        max = Math.Max(k, max);
                    }
                    else
                        k = 1;

                for (int i = 1; i < s.Length; i++)
                    if (s[i] == s[i - 1])
                    {
                        k += 1;
                        if (k == max)
                            Console.WriteLine($"{s[i]} {k}");
                    }
                    else
                        k = 1;
            }

            internal virtual void Solution_83()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k8data\k8-7.txt");

                int count = 0, max = 0;
                for (int i = 0; i < s.Length - 1; i++)
                    if (s[i] != s[i + 1])
                    {
                        count++;
                        max = Math.Max(count, max);
                    }
                    else
                    {
                        max = Math.Max(count, max);
                        count = 1;
                    }

                Console.WriteLine(max);
            }

            internal virtual void Solution_87() =>
                throw new NotImplementedException();

            internal virtual void Solution_102()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\24-4.txt");

                string res = s[0].ToString(), max = "";
                for (int i = 1; i < s.Length; i++)
                    if (s[i] > s[i - 1])
                    {
                        res += s[i];
                        max = res.Length > max.Length ? res : max;
                    }
                    else
                    {
                        max = res.Length > max.Length ? res : max;
                        res = s[i].ToString();
                    }

                Console.WriteLine(max);
            }

            internal virtual void Solution_136() =>
                throw new NotImplementedException();

            internal virtual void Solution_137() =>
                throw new NotImplementedException();

            internal virtual void Solution_140() =>
                throw new NotImplementedException();

            internal virtual void Solution_145() =>
                throw new NotImplementedException();
        }

        internal class SolutionsForLinq : SolutionsForDefolt
        {
            internal override void Solution_7()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7-40.txt");

                int max = 0;
                for (int i = 0; i < s.Length; i++)
                    max = Math.Max(s[i..].TakeWhile(x => x == 'C').Count(), max);

                Console.WriteLine(max);
            }

            internal override void Solution_22()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7a-2.txt");

                int max = 0;
                for (int i = 0; i < s.Length; i++)
                    max = Math.Max(s[i..].TakeWhile(x => "ADC".Contains(x)).Count(), max);

                Console.WriteLine(max);
            }

            internal override void Solution_87()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\24-1.txt");

                int max = 0;
                for (int i = 0; i < s.Length; i++)
                    max = Math.Max(int.Parse("0" + String.Join("", s[i..].TakeWhile(x => Int32.TryParse(x.ToString(), out int y)))), max);

                Console.WriteLine(max);
            }

            internal override void Solution_137()
            {
                string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\24-s1.txt");

                Console.WriteLine(s.Where(v => v.Count(x => x == 'J') > v.Count(x => x == 'E')).Count());
            }

            internal override void Solution_145()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\24-j7.txt");

                int ch = 0, nh = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    ch = Math.Max(int.Parse(String.Join("", s[i..].TakeWhile(w => int.TryParse(w.ToString(), out int y) && int.Parse(w.ToString()) % 2 == 0))), ch);
                    nh = Math.Max(int.Parse(String.Join("", s[i..].TakeWhile(w => int.TryParse(w.ToString(), out int y) && int.Parse(w.ToString()) % 2 != 0))), nh);
                }

                Console.WriteLine(Math.Max(ch, nh));
            } //??
        }

        internal class SolutionsForRegex : SolutionsForDefolt
        {
            internal override void Solution_7()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7-40.txt");

                Console.WriteLine(Regex.Matches(s, @"(C)\1*").Select(x => x.Value.Length).Max());
            }

            internal override void Solution_22()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k7data\k7a-2.txt");

                Console.WriteLine(Regex.Matches(s, @"[A|C|D]*").Select(x => x.Value.Length).Max());
            } 

            internal override void Solution_52()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k8data\k8-0.txt ");

                var mh = Regex.Matches(s, @"(\w)\1*").Select(m => m.Value.Length).Max();
                var mh2 = Regex.Matches(s, @"(\w)\1*").Where(x => x.Value.Length == mh).ToList()[0].Value.ToString()[0];

                Console.WriteLine($"{mh2} {mh}");
            }

            internal override void Solution_62()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\k8data\k8-55.txt");

                var a = Regex.Matches(s, @"(\w)\1*").Select(x => x.Value.Length).Max();
                var b = Regex.Matches(s, @"(\w)\1*").Where(x => x.Value.Length == a).ToList()[0].Value.ToString()[0];

                Console.WriteLine($"{b} {a}");
            }

            internal override void Solution_136()
            {
                string s = File.ReadAllText(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\24-j5.txt");

                Console.WriteLine(Regex.Matches(s, @"([^S][T]OCK)|([S][^T]OCK)|([^S][^T]OCK)").Count());
            }

            internal override void Solution_140()
            {
                string[] s = File.ReadAllLines(@"D:\hem12\Documents\Документы Миша\Школьные предметы\ЕГЭ информатика\Задания ЕГЭ с Полякова\24data\24-s1.txt");

                Console.WriteLine(s.Where(v => Regex.Matches(v, @"YZ").Count > 1).Count());
            }
        }
    }
}
