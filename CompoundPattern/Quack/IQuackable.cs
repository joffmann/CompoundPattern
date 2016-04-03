using System;
namespace CompoundPattern.Quack
{
    public interface IQuackable : IObservable<IQuackable>
    {
        void Quack();
    }
}
