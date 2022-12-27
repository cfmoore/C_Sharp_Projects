using System;

/**
     public 	The code is accessible for all classes
     private 	The code is only accessible within the same class
     protected 	The code is accessible within the same class, or in a class that is inherited from that class. 
     internal 	The code is only accessible within its own assembly, but not from another assembly.
*/
namespace Beginning
{
    public class Car
    {
        protected string make;
        protected string model;
        private int year;
        public bool inprod;
        /**Optional Parameters in constructors must be at the end
         * You cannot make the first optional and the rest required
         * You can see by removing unkown in the code below, there is an error.
         * It also seems that the THIS keyword is differnt in C#, nomenclature is _ infront of parameter
         * */
        public Car(string _make, string _model = "Unknown", int _year=0)
        {
            make = _make;
            model = _model;
            year = _year;
            inprod = true;
        }

        //Overloaded constructor
        public Car(bool _inprod, string _make, string _model = "Unknown", int _year = 0)
        {
            make = _make;
            model = _model;
            year = _year;
            inprod = _inprod;
        }

        //Blank Constructor for Inheritance
        public Car()
        {
            make = null;
            model = null;
            year = 0;
        }

        //These are properties, Note that it is a getter and setter of the variables above
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public bool getInProd()
        {
            return inprod;
        }

        public void setInProd(bool _inprod)
        {
            inprod = _inprod;
        }

        public virtual void Print()
        {
            Console.WriteLine(make + " " + model + " " + year);
        }
    }


}
