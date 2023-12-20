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
        internal string? Date { get; private set; }
        internal string? TimeStamp { get; private set; }

        internal bool isInputCorrect { get; private set; } = true;
        internal RandomForWork()
        {
            Console.WriteLine("Минимально возможный месяц: ");
            var isParseOk = int.TryParse(Console.ReadLine(), out int minMonth);
            if (isParseOk && minMonth > 0 && minMonth <= 12)
            {
                MinMonth = minMonth;
            }
            else
            {   
                Console.WriteLine("Нужно ввести число от 1 до 12, рандом не сработает, го заново!");
                isInputCorrect = false;
            }
            if (isInputCorrect)
            {
                Console.WriteLine("Максимально возможный месяц: ");
                isParseOk = int.TryParse(Console.ReadLine(), out int maxMonth);
                if (isParseOk && maxMonth > 0 && maxMonth <= 12)
                {

                    MaxMonth = maxMonth;
                }
                else
                {
                    Console.WriteLine("Нужно ввести число от 1 до 12, рандом не сработает, го заново!");
                    isInputCorrect = false;
                }
                if (isInputCorrect)
                {
                    BaseRnd = new Random();
                }
            }
           
        }
        internal void RandomTimeStamp()
        {
            if(BaseRnd != null)
            {
                var hours = BaseRnd.Next(0, 24);
                var minutes = BaseRnd.Next(0, 60);
                var seconds = BaseRnd.Next(0, 60);
                string timeStamp = $"{hours}:{minutes}:{seconds}";
                TimeStamp = timeStamp;
            }
        }

        internal void RandomDate()
        {
            if(BaseRnd != null)
            {
                var day = BaseRnd.Next(1, 31);
                var month = BaseRnd.Next(MinMonth, MaxMonth + 1);
                string randomDate = $"{day}.{month}.2022";
                Date = randomDate;
            }
        }
    }
}
