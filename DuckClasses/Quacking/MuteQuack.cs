using System;

namespace DuckClasses.Quacking
{
    public class MuteQuack: IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("I can't make a sound.");
        }
    }
}
