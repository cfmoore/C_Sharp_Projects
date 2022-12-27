using System;

namespace Beginning
{
    class Loops
    {
        public void runner()
        {
            //While Loops
            // Can use Break to exit or Continue to skip iteration
            int i = 0;
            while (i < 5)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.Write('\n');
            i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i < 5);
            Console.Write('\n');

            //For Loops
            // Can use Break to exit or Continue to skip iteration
            for (i = 0; i < 10; i += 2)
                Console.Write(i + " ");
            Console.Write('\n');
            //For each, powerful loop through an array, better for complex arrays and dicts.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int j in numbers)
                Console.Write(j + " ");
            Console.Write('\n');

        }
    }
}
