using CompoundPattern.Quack;

namespace CompoundPattern.Duck
{
    /// <summary>
    /// Factory pattern
    /// </summary>
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallarDuck()
        {
            // Instans med decorator
            return new QuackCounter(new MallardDuck());
        }
        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }
        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }
        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
