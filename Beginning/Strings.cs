using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning
{
    class Strings
    {
        public void runner()
        {
            //String Operators
            string fname = "Chad";
            string lname = "Moore";
            string name = fname + " " + lname;
            string greeting = $"My full name is: {fname} {lname}";//String Interpolation *****NOTE THE $
            Console.WriteLine(greeting);
            //Strings are like char arrays
            Console.WriteLine(fname[0]);
            Console.WriteLine(fname.IndexOf("h"));//Should output 1
            int charPos = name.IndexOf("M");
            //You can Overload the Method and also give ending positions.
            lname = name.Substring(charPos);//Will start at M and continue until end.
            Console.WriteLine("This is after using substring: " + lname);
            lname = name.Substring(charPos, 2);
            Console.WriteLine("This is after using substring overloaded: " + lname);
            Console.WriteLine("The Length of the string name is: " + name.Length);
        }
    }
}
