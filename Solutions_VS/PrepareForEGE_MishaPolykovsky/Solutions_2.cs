using System;
using System.Collections.Generic;
using System.Text;

namespace PrepareForEGE_MishaPolykovsky
{
    internal class Solutions_2
    {
        internal static void Start(object use = null, ISolution.StartupOptions startupOptions = ISolution.StartupOptions.Include) =>
            ISolution.Start(new Solutions_2(), use, startupOptions);

        internal static void Solution_184()
        {
            var table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if ((((!x || y) && (!y || w)) || ((x && z) || (y && z) || (!x && !y && !z))) == false)
                                Console.WriteLine($"{Convert.ToInt32(x)} {Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(w)}");
        }

        internal static void Solution_187()
        {
            var table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if ((((!x || y) && !z) || w) == false)
                                Console.WriteLine($"{Convert.ToInt32(y)} {Convert.ToInt32(w)} {Convert.ToInt32(x)} {Convert.ToInt32(z)}");
        }

        internal static void Solution_190()
        {
            var table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if ((((!x || z) && (!z || w)) || ((x && y) || (y && z) || (!x && !y && !z))) == false)
                                Console.WriteLine($"{Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(w)} {Convert.ToInt32(x)}");
        }

        internal static void Solution_191()
        {
            var table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if (((x && !y) || ((y && z) || (!y && !z)) || w) == false)
                                Console.WriteLine($"{Convert.ToInt32(y)} {Convert.ToInt32(x)} {Convert.ToInt32(w)} {Convert.ToInt32(z)}");
        }

        internal static void Solution_193()
        {
            var table = new[] { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if (((!x && !y) || (x && y) || (!y && w && z) || (!x && !z) || (!w && !z)) == false)
                                Console.WriteLine($"{Convert.ToInt32(y)} {Convert.ToInt32(z)} {Convert.ToInt32(x)} {Convert.ToInt32(w)}");
        }

        internal static void Solution_196()
        {
            bool[] table = { false, true };

            foreach (bool x in table)
                foreach (bool y in table)
                    foreach (bool z in table)
                        foreach (bool w in table)
                            if ((!y || x || (!z && w)) == (w == x))
                                Console.WriteLine($"{Convert.ToInt32(x)} {Convert.ToInt32(w)} {Convert.ToInt32(y)} {Convert.ToInt32(z)}");
        }
    }
}
