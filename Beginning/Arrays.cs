using System;

namespace Beginning
{
    class Arrays
    {
        public void runner()
        {
            //Arrays
            //Based 0
            // array.Length gets the length of the array
            //Creates an array of size 4 with a name and no values.
            // array.Sort() Will sort alphabetically or in Ascending order
            string[] cars = new string[4];
            // Create an array of four elements and add values right away 
            string[] acars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements without specifying the size 
            string[] bcars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] ccars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Decalre an Array
            string[] dcars;
            //YOU MUST USE NEW KEYWORD NOW and constructor.
            dcars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine("Length of array: " + dcars.Length);
            foreach (string a in dcars)
                Console.WriteLine(a);
            /** System.Linq Namespace
             * using System.Linq;
             * allows actions on arrays
             * array.Max(), array.Min(), array.Sum()
             * */
            //Multidimensional Arrays
            int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int j = 0; j < nums.GetLength(0); j++)
            {
                for (int k = 0; k < nums.GetLength(1); k++)
                {
                    Console.Write(nums[j, k] + " ");
                }
                Console.Write('\n');
            }
        }
    }
}
