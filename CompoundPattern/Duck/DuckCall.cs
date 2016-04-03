using System;
using CompoundPattern.Quack;


namespace CompoundPattern.Duck
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
