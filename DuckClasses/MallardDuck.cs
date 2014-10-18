using DuckClasses.Flying;
using DuckClasses.Quacking;
using System;

namespace DuckClasses
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}
