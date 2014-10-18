using DuckClasses.Flying;
using DuckClasses.Quacking;
using System;

namespace DuckClasses
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            setQuackBehavior = new Quack();
            setFlyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a Mallard Duck");
        }
    }
}
