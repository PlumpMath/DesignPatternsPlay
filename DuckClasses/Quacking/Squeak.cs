using System;

namespace DuckClasses.Quacking
{
    public class Squeak: IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("squeak squeak squeak");
        }
    }
}
