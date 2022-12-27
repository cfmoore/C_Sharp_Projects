using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning
{
    class Motorcycle : Car
    {
        private double topSpeed;
        public Motorcycle(string _make, string _model, int _year, double _topspeed)
        {
            //Protected Variables can be accessed by inheritance
            make = _make;
            model = _model;
            //Notice we use the property instead of direct variable assignment
            Year = _year;
            //Public doesn't matter
            inprod = true;

            topSpeed = _topspeed;
        }
        public double TopSpeed
        {
            get { return topSpeed; }
            set { topSpeed = value; }
        }
        public override void Print()
        {
            Console.WriteLine(make + " " + model + " " + topSpeed);
        }
    }
}
