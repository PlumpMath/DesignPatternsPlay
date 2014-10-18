using System;
using DuckClasses.Flying;
using DuckClasses.Quacking;

namespace DuckClasses
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void display()
        {
            Console.WriteLine("I am a rubber duck.");
        }

    }
}
