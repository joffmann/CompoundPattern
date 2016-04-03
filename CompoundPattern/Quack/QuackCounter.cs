namespace CompoundPattern.Quack
{

    /// <summary>
    /// Decorator Pattern
    /// </summary>
    public class QuackCounter : IQuackable
    {
        IQuackable _duck;
        static int numberOfQuacks;
        
        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            numberOfQuacks++;
        }

        public static int GetQuacks()
        {
            return numberOfQuacks;
        }
    }
}
