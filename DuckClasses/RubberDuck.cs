using System;

namespace DuckClasses
{
    public class RubberDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I am a rubber duck.");
        }

        public override void quack()
        {
            Console.WriteLine("Squeak Squeak from rubber duck.");
        }
    }
}
