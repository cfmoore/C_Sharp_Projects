using System;
namespace Beginning
{
    class Program
    {
        //Simple addition function for basics.
        static int add1(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //This is a method where there is a default value, if no parameters are passed
        static void print(string n = "NoName")
        {
            Console.WriteLine("Hello " + n + ", how are you doing?");
        }

        //This is for showing out of order loading
        static void outOfOrder(int a, int b, int c)
        {
            Console.WriteLine("A was: " + a + "\nB was: " + b + "\nC was: " + c);
        }

        //Overloading Methods
        //If the methods have the same name but different parameters or different amount of parameters, they can have the same name
        static int plusMethod(int a, int b)
        {
            return a + b;
        }

        static int plusMethod(double a, double b)
        {
            return (int)a + (int)b;
        }
        static void Main(string[] args)
        {
            /*
             * Break Out Character is \
             * \' -> '
             * \" -> "
             * \\ -> \
             * \n return, \t tab, \b backspace.
             * */
            Console.WriteLine("Hello World!");
            Console.WriteLine(3 + 3);
            Console.Write("This will not have a carriage return, ");
            Console.Write("Unless you add the break character \\n \n");

            //Conversion Methods
            string temp = "55";
            double dud = 55.326D;
            Console.WriteLine("This is now a string: "+Convert.ToString(dud));
            Console.WriteLine("This is now a double: "+Convert.ToDouble(temp));
            Console.WriteLine("This is now an int: " +Convert.ToInt32(temp));


            //Getting user based input from console
            //ReadLine() only returns a string
            //***************************************READING INPUT FROM CONSOLE
            /*Console.WriteLine("Enter Name:");
            string userName = Console.ReadLine();//Without the Declaration, the line is read and tossed
            Console.WriteLine("User Name is: "+userName + "      Length of: " + userName.Length);*/

            //BITWISE Assignment Operators
            // &=   |=  ^=  >>=     <<=
            //Math Operators
            Math.Max(5, 10);
            Math.Min(5, 10);
            Math.Sqrt(64);
            Math.Abs(-4.7);
            Math.Round(9.99);
            Math.Ceiling(9.1);
            Math.Floor(9.9);

           
            
            //Methods
            Console.WriteLine("Value returned " + add1(100, 69));
            print("chad");//Will print full name
            print();//Will print no name
            //Named Arguments in Methods
            //Cannot think of a use case for this
            outOfOrder(c: 3, a: 1, b: 2);//Will print in order of method, but we are changing the order in which we send
            //Overloading Methods
            Console.WriteLine("As Ints: "+plusMethod(5, 6));
            Console.WriteLine("As Doubles: " + plusMethod(5.986654, 11.21513));
            /*Samples
            Variables v = new Variables();
            v.runner();
            Strings s = new Strings();
            s.runner();
            IfElse ie = new IfElse();
            ie.runner();
            Loops l = new Loops();
            l.runner();
            Arrays arr = new Arrays();
            arr.runner();
            Enumerators ee = new Enumerators();
            ee.runner();*/
            FileIO fio = new FileIO();
            fio.runner();

            //Class
            Car mc = new Car("Kia", "Sportage", 2023);
            mc.Print();
            /*Console.WriteLine("Grabbing Public Variable: " + mc.inprod);
            Console.WriteLine("Grabbing private Variable: "+mc.Make);
            Console.WriteLine("Changing year from " + mc.Year + " to 2022");
            mc.Year = 2022;
            Console.WriteLine("Year Changed to: " + mc.Year);
            Car mm = new Motorcycle("Kawasaki", "Ninja", 2021, 232.31);
            //Figure out how to assign veriables for a inherited class
            //mm.TopSpeed = 232.33;
            mm.Print();*/

            // Abstraction Example
            Pig mp = new Pig();
            mp.animalSound();
            mp.sleep();

            //Interface Example
            Store st = new Store();
            st.getFruit();
            st.getVegetables();

        }
    }


}
