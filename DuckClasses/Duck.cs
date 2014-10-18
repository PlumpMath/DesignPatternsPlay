using System;

namespace DuckClasses
{
    public abstract class Duck
    {
        public abstract void display();
        
        public virtual void quack() {
            Console.WriteLine("quack from the base class");
        }

        public virtual void swim()
        {
            Console.WriteLine("Base Duck is swimming.");
        }

        public virtual void fly()
        {
            Console.WriteLine("I am a duck flying");
        }

    }
}
