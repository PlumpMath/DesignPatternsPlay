using System;
using DuckClasses.Flying;
using DuckClasses.Quacking;

namespace DuckClasses
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public abstract void display();
        
        /// <summary>
        /// Switching to an interface call
        /// </summary>
        public void performQuack() {
            quackBehavior.quack();
        }

        public virtual void swim()
        {
            Console.WriteLine("Base Duck is swimming.");
        }

        /// <summary>
        /// Switching to an interface call
        /// </summary>
        public void performFly()
        {
            flyBehavior.fly();
        }

    }
}
