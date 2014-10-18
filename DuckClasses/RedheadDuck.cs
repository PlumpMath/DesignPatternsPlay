using DuckClasses.Flying;
using DuckClasses.Quacking;
using System;

namespace DuckClasses
{
    public class RedheadDuck: Duck
    {
        public RedheadDuck()
        {
            setQuackBehavior = new Quack();
            setFlyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a redheaded duck.");
        }
    }
}
