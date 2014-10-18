using DuckClasses.Flying;
using DuckClasses.Quacking;
using System;

namespace DuckClasses
{
    public class RedheadDuck: Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a redheaded duck.");
        }
    }
}
