using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckClasses;

namespace DuckChap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.quack();
            mallard.fly();

            Duck redhead = new RedheadDuck();
            redhead.display();
            redhead.quack();
            redhead.fly();

            Duck rubber = new RubberDuck();
            rubber.display();
            rubber.quack();
            rubber.fly();
        }
    }
}
