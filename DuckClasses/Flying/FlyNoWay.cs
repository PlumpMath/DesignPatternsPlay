using System;

namespace DuckClasses.Flying
{
    public class FlyNoWay: IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
