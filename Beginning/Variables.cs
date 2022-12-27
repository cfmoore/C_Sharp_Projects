using System;


namespace Beginning
{
    class Variables
    {
        public void runner()
        {
            //Variable Types
            string fname = "Chad";
            string lname = "Moore";
            string name = fname + lname;
            char flag = 'c';
            char intFlag = (char)96;//Example of casting
            int mynum = 98;
            double mydec = 59.99D;//***NOTE THE D AFTER THE NUMBER
            bool mybool = false;
            int newInt;
            newInt = 100;
            const double tax = 7.75D;//Constant

            //Outputting Variable Basic
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Chars " + flag + " " + intFlag);
            Console.WriteLine("Adding: " + (mynum + mydec));
            Console.WriteLine(mybool + " Constant Math: " + (newInt * tax));

            //Multivariable Declarations
            int x = 5, y = 6, z = 7;
            Console.WriteLine(x + y + z);
            int q, r, s;
            q = r = s = 13;
            Console.WriteLine(q + r + s);
            /**
                *  int 	4 bytes 	Stores whole numbers from -2,147,483,648 to 2,147,483,647
                long 	8 bytes 	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                float 	4 bytes 	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
                double 	8 bytes 	Stores fractional numbers. Sufficient for storing 15 decimal digits
                bool 	1 bit 	Stores true or false values
                char 	2 bytes 	Stores a single character/letter, surrounded by single quotes
                string 	2 bytes per character 	Stores a sequence of characters, surrounded by double quotes
                */

            long newLong = 15000000000L;//Note the L
            float myFloat = 5.75F;//Note the F
            Console.WriteLine(newLong + " " + myFloat);

            //Casting
            //Automatic Casting (Implicit)
            //char -> int -> long -> float -> double
            //You can cast upward automatically. 
            //IE if it is a smaller value, it will cast automatically to the higher data type.
            //************************************************************************************
            //Manual Casting (Explicit)
            //double -> float -> long -> int -> char
            //Going backwards, you have to manually tell the compiler which vaule you are dropping.

            //Implicit this will output 10.1
            int cuint = 5;
            double dud = 5.1D;
            Console.WriteLine(cuint + dud);
            //Explicit This will output 10
            Console.WriteLine(cuint + (int)dud);
        }
    }
}
