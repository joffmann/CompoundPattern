using System;
using CompoundPattern.Quack;

namespace CompoundPattern.Duck
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {

            Console.WriteLine("Quack");
        }
    }
}
