﻿using System;
using System.Linq;
using System.Reflection;
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

        public static void Start(object obj, object toConvertUse = null, StartupOptions startupOptions = StartupOptions.Include)
        {
            string[] use;
            if (toConvertUse == null)
                use = null;
            else
                use = toConvertUse.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var methods = obj.GetType().GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic);
            for (int i = 0; i < methods.Length; i++)
            {
                if (startupOptions == StartupOptions.Include)
                {
                    if ((methods[i].Name != "Start") && Check(methods[i].Name, use))
                    {
                        Console.WriteLine("Номер " + String.Join("", Regex.Matches(methods[i].Name, @"(\d)\1*").Select(x => x.Value)) + ":");

                        try { methods[i].Invoke(obj, null); }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        };

                        Console.WriteLine();
                    }
                }
                else if ((methods[i].Name != "Start") && !Check(methods[i].Name, use))
                {
                    Console.WriteLine("Номер " + String.Join("", Regex.Matches(methods[i].Name, @"(\d)\1*").Select(x => x.Value)) + ":");

                    try { methods[i].Invoke(obj, null); }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    };

                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Такого решенея нема :(");
            }
        }

        private static bool Check(string methodName, string[] use = null)
        {
            if (use == null)
                return true;

            if (use.Contains(String.Join("", Regex.Matches(methodName, @"(\d)\1*").Select(x => x.Value))))
                return true;

            return false;
        }
    }
}
