using System;

namespace DuckClasses.Quacking
{
    public class Quack: IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("quack quack quack.");
        }
    }
}
