using System;

namespace DuckClasses.Flying
{
    public class FlyRocketPowered: IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying with a rocket pack.");
        }
    }
}
