using CompoundPattern.Quack;
namespace CompoundPattern.Goose
{
    /// <summary>
    /// Adapter Pattern
    /// </summary>
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.honk();
        }
    }
}
