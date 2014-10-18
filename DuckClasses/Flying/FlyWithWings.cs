using System;

namespace DuckClasses.Flying
{
    public class FlyWithWings: IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying with wings flapping.");
        }
    }
}
