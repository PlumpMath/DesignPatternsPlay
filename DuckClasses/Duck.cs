using System;
using DuckClasses.Flying;
using DuckClasses.Quacking;

/*
 *   Switching to use setters for the fly and quack behaviors.
 *       allows program to dynamically change behaviors 
 */
namespace DuckClasses
{
    public abstract class Duck
    {
        // Switching Interfaces to properties so can inject or dynamically change at runtime...
        private IFlyBehavior _flyBehavior;
        public IFlyBehavior setFlyBehavior {
            set { _flyBehavior = value; }        
        }

        private IQuackBehavior _quackBehavior;
        public IQuackBehavior setQuackBehavior {
            set { _quackBehavior = value; }
        }

        public abstract void display();
        
        /// <summary>
        /// Switching to an interface call
        /// </summary>
        public void performQuack() {
            _quackBehavior.quack();
        }

        /// <summary>
        /// Switching to an interface call
        /// </summary>
        public void performFly()
        {
            _flyBehavior.fly();
        }

        //Other Duck Methods
        public virtual void swim()
        {
            Console.WriteLine("Base Duck is swimming.");
        }
    }
}
