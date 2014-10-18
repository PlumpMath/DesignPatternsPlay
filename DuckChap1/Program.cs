using System;
using DuckClasses;
using DuckClasses.Flying;

namespace DuckChap1
{
    /*   Design Principles    
     *      1. Identify the aspects of your application that vary and separate them from what stays the same.
     *              - forms the basis for almost every design pattern
     *      2. Program to an interface, not an implementation.
     *              - also includes abstract classes
     *      3. Favor composition over inheritance
     *              - encapsulate and change behavior at runtime
     *              
     *  Strategy Pattern - defines a family of algorithms, encapsulates each one, and makes them interchangeable.
     *      Strategy lets the algorithm vary independently from the clients that use it.
     *      
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ** This is Duck Fly Learning Program from Head First Design Patterns \n Chap 1 - Strategy Pattern ** \n\n");

            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performQuack();
            mallard.performFly();

            Console.WriteLine();

            Duck redhead = new RedheadDuck();
            redhead.display();
            redhead.performQuack();
            redhead.performFly();

            Console.WriteLine();

            Duck rubber = new RubberDuck();
            rubber.display();
            rubber.performQuack();
            rubber.performFly();

            Console.WriteLine();
            Console.WriteLine("Adding Rocket Power to Rubber Duck");
            Console.WriteLine();

            // setting fly behavior for rubber ducky
            rubber.setFlyBehavior = new FlyRocketPowered();
            rubber.display();
            rubber.performFly();
        }
    }
}
