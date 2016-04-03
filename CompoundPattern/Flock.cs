
using System.Collections.Generic;
using CompoundPattern.Quack;


namespace CompoundPattern
{
    /// <summary>
    /// Iterator pattern
    /// </summary>
    public class Flock : IQuackable
    {
        List<IQuackable> _quackers = new List<IQuackable>();
        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach(var quacker in _quackers)
            {
                quacker.Quack();
            }
        }
    }
}
