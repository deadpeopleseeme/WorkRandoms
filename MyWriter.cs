using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkCSRandomizer
{  
    internal class MyWriter
    {
        private RandomForWork RandomInWriter { get; }

        internal MyWriter()
        {
            RandomInWriter = new RandomForWork();
        }

        internal void WriteRandomsToFile(string path)
        {
            var text = "";
            for (int i = 0; i < 10; i++)
            {
                RandomInWriter.RandomDate();
                RandomInWriter.RandomTimeStamp();
                var textToAdd = $"{RandomInWriter.Date} {RandomInWriter.TimeStamp}\n";
                text += textToAdd;
            }
            using StreamWriter sw = new(path);
            sw.WriteLine(text);
        }
    }
}
