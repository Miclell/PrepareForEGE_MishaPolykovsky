using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrepareForEGE_MishaPolykovsky
{
    public interface ISolution
    {
        public enum StartupOptions
        {
            Include = 0,
            Exclude = 1
        }

        public static void Start(object type, object toConvertUse = null, StartupOptions startupOptions = StartupOptions.Include)
        {
            string[] use;
            if (toConvertUse == null)
                use = null;
            else
                use = toConvertUse.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var methods = type.GetType().GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic);

            List<string> nonSolution = new List<string>();

            foreach (MethodInfo mi in methods)
            {
                if (startupOptions == StartupOptions.Include &&
                    mi.Name != "Start" && Check(mi.Name, use))
                {
                    Console.WriteLine("Номер " + String.Join("", Regex.Matches(mi.Name, @"\d*").Select(x => x.Value)) + ":");

                    try { mi.Invoke(type, null); }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    };

                    Console.WriteLine();
                }
                else if (startupOptions != StartupOptions.Include && (mi.Name != "Start") && !Check(mi.Name, use))
                {
                    Console.WriteLine("Номер " + String.Join("", Regex.Matches(mi.Name, @"\d*").Select(x => x.Value)) + ":");

                    try { mi.Invoke(type, null); }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    };

                    Console.WriteLine();
                }
                else
                {
                    nonSolution.Add(use[0]);
                }
            }

            if (nonSolution.Count > 0)
            {
                nonSolution = methods.Where(x => x.Name != "Start" && !Check(x.Name, use)).Select(x => x.Name).ToList();
                Console.WriteLine(string.Join("\n", nonSolution.Select(x => Regex.Matches(x, @"\d*").Select(x => x.Value).ToList().Count)));
                Console.WriteLine(string.Join("\n", nonSolution.Select(x => Regex.Match(x, @"\d*", RegexOptions.Compiled).Value)));
                Console.WriteLine(String.Join("Решения ", nonSolution.Select(x => Regex.Matches(x, @"\d*").Select(x => x.Value + " нема:("))));
            }
        }

        private static bool Check(string methodName, string[] use = null)
        {
            if (use == null)
                return true;

            if (use.Contains(String.Join("", Regex.Matches(methodName, @"\d*").Select(x => x.Value))))
                return true;

            return false;
        }

        //private static bool GetNonMethods(List<string> nonContains, MethodInfo[] mi)
    }
}
