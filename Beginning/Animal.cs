using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning
{
    //Abstraction
/**
 * 
 *  Data abstraction is the process of hiding certain details and showing only essential information to the user.
 *  Abstraction can be achieved with either abstract classes.
 *  The abstract keyword is used for classes and methods:
 *  --Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
 *  --Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
 *  An abstract class can have both abstract and regular methods. 
 */
abstract class Animal
{
        //Note abstract keyword which means that only inherited classes can access this constructor
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("ZZZZZZZZzzzzzzzzzzzzz");
    }
}

    //Internal is because the class is inside another class program, this is not necessary if it is written in the main.
internal class Pig : Animal
{ 
        // @ Override takes control away from the contructor method 
    public override void animalSound()
    {
        Console.WriteLine("Oink Oink Oink Oink Oink");
    }
}


}
