using System;
using CompoundPattern.Quack;

namespace CompoundPattern.Duck
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
