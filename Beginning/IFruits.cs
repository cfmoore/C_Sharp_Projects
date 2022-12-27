using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning
{
    /**
     * An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):
     * It is considered good practice to start with the letter "I" at the beginning of an interface, 
     * as it makes it easier for yourself and others to remember that it is an interface and not a class.
     *    --By default, members of an interface are abstract and public.
     *    
     * Like abstract classes, interfaces cannot be used to create objects (in the example, it is not possible to create an "IFruit" object in the Program class)
     * Interface methods do not have a body - the body is provided by the "implement" class
     * On implementation of an interface, you must override all of its methods
     * Interfaces can contain properties and methods, but not fields/variables
     * Interface members are by default abstract and public
     * An interface cannot contain a constructor (as it cannot be used to create objects.
     * 
     * USES
     * 1) To achieve security - hide certain details and only show the important details of an object (interface).
     * 2) C# does not support "multiple inheritance" (a class can only inherit from one base class). 
     * However, it can be achieved with interfaces, because the class can implement multiple interfaces. 
     * Note: To implement multiple interfaces, separate them with a comma (see example below).
     */

    interface IFruits
    {
        void getFruit();
    }

    interface IVegetables
    {
        void getVegetables();
    }

    class Store: IFruits, IVegetables
    {
        public void getFruit()
        {
            Console.WriteLine("Apples and Bananas");
        }
        public void getVegetables()
        {
            Console.WriteLine("Lettuce and Celery");
        }
    }
}
