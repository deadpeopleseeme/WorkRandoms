using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkCSRandomizer
{
    internal class RandomForWork
    {
        private Random BaseRnd { get; }

        internal int MinMonth { get; }

        internal int MaxMonth { get; }
        internal string Date { get; private set; }
        internal string TimeStamp { get; private set; }
        internal RandomForWork()
        {
            MinMonth = 9;
            MaxMonth = 12;
            BaseRnd = new Random();
        }
        internal void RandomTimeStamp()
        {
            var hours = BaseRnd.Next(0, 24);
            var minutes = BaseRnd.Next(0, 60);
            var seconds = BaseRnd.Next(0, 60);
            string timeStamp = $"{hours}:{minutes}:{seconds}";
            TimeStamp = timeStamp;
        }

        internal void RandomDate()
        {
            var day = BaseRnd.Next(1, 31);
            var month = BaseRnd.Next(MinMonth, MaxMonth + 1);
            string randomDate = $"{day}.{month}.2022";
            Date = randomDate;
        }
    }
}
