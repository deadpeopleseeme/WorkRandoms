using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkCSRandomizer
{
    internal static class MyReader
    {
        internal static void ReadRandomsFromFile(string path)
        {
            using StreamReader sr = File.OpenText(path);
            string strFromFile = "";
            while ((strFromFile = sr.ReadLine()) != null)
            {
                Console.WriteLine(strFromFile);
            }
        }
    }
}
