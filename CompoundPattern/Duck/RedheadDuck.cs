using System;
using CompoundPattern.Quack;

namespace CompoundPattern.Duck
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
