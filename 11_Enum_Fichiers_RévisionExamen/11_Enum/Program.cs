using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enum
{
    internal class Program
    {
        enum Level
        {
            LOW,
            MEDIUM,
            HIGH,
        }


        static void Main(string[] args)
        {
            Level level = Level.MEDIUM;
            Console.WriteLine(level);
            int val = (int)level;
            Console.WriteLine(val);
            Months mois = Months.AVRIL;
            int val2 = (int)mois;
            Console.WriteLine(val2);

            switch (level)
            {
                case Level.LOW:
                    Console.WriteLine("Low level");
                    break;
                case Level.MEDIUM:
                    Console.WriteLine("Medium level");
                    break;
                case Level.HIGH:
                    Console.WriteLine("High level");
                    break;
            }
        }
    }
}
