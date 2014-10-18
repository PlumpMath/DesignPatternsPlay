using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckClasses;

namespace DuckChap1
{
    /*   Design Principles    
     *      1. Identify the aspects of your application that vary and separate them from what stays the same.
     *              - forms the basis for almost every design pattern
     *      2. Program to an interface, not an implementation.
     *              - also includes abstract classes
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performQuack();
            mallard.performFly();

            Duck redhead = new RedheadDuck();
            redhead.display();
            redhead.performQuack();
            redhead.performFly();

            Duck rubber = new RubberDuck();
            rubber.display();
            rubber.performQuack();
            rubber.performFly();
        }
    }
}
