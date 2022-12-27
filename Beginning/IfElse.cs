using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning
{
    class IfElse
    {
        public void runner()
        {
            //If Else
            int small = 5;
            Console.WriteLine("Enter an int to compare to 5");
            int inputted = Convert.ToInt32(Console.ReadLine());
            if (small < inputted)
            {
                Console.WriteLine("Bigger");
            }
            else if (small == inputted)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Must be smaller");
            /*Shorthand If else
             * Cannot handle multiple outputs. It is either true or false. No else.
             * Can be returned in a method
             * If true, Before : is executed.
             * */
            Console.WriteLine((small > inputted) ? "Bigger" : "Smaller");

            //Switch Statements
            //Standard Rules, it will enter where the condition is true and will run through until the break is met.
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default://Default exit condition
                    Console.WriteLine("Not a day of the week");
                    break;
            }
        }
    }
}
