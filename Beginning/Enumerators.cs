using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning
{
    class Enumerators
    {
        enum Level
        {
            None = 0,
            Low = 2,
            Medium = 5,
            High = 7,
            Critical = 10
        }
        public void runner()
        {
            //Accessing Enumerators
            Level ml1 = Level.High;
            Console.Write(ml1 + " ");
            //Casting Enums
            int ml2 = (int)Level.Medium;
            Console.WriteLine(ml2);
            //Common Use Case is Switch
            switch (ml1)
            {
                case Level.Low:
                    Console.WriteLine(ml1);
                    break;
                case Level.Medium:
                    Console.WriteLine(ml1);
                    break;
                case Level.High:
                    Console.WriteLine(ml1);
                    break;
                case Level.Critical:
                    Console.WriteLine(ml1);
                    break;
            }
        }
    }
}
