using System;
using CompoundPattern.Duck;
using CompoundPattern.Goose;
using CompoundPattern.Quack;

namespace CompoundPattern
{
    public class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory _duckFacktory = new CountingDuckFactory();
            simulator.simulate(_duckFacktory);
        }

        private void simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallarDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new QuackCounter(new GooseAdapter(new Goose.Goose()));

            Flock _flockOfMallards = new Flock();
            IQuackable mallardDuckOne = duckFactory.CreateMallarDuck();
            IQuackable mallardDuckTwo = duckFactory.CreateMallarDuck();
            IQuackable mallardDuckThree = duckFactory.CreateMallarDuck();
            IQuackable mallardDuckFour = duckFactory.CreateMallarDuck();
            _flockOfMallards.Add(mallardDuckOne);
            _flockOfMallards.Add(mallardDuckTwo);
            _flockOfMallards.Add(mallardDuckThree);
            _flockOfMallards.Add(mallardDuckFour);
            _flockOfMallards.Quack();

            //IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            //IQuackable redheadDuck = new QuackCounter(new RedheadDuck());
            //IQuackable duckCall = new QuackCounter(new DuckCall());
            //IQuackable rubberDuck = new QuackCounter(new RubberDuck());
            //IQuackable gooseDuck = new QuackCounter(new GooseAdapter(new Goose.Goose()));

            Console.WriteLine("Duck Simulator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);

            Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks() + " times.");

        }

        void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
