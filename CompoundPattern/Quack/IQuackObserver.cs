using System;
using System.Collections.Generic;



namespace CompoundPattern.Quack
{
    /// <summary>
    /// Observer Pattern Provider
    /// 
    /// The IObserver<T> and IObservable<T> interfaces provide a generalized mechanism for push-based notification, 
    /// also known as the observer design pattern. The IObservable<T> interface represents the class that sends notifications (the provider);
    /// </summary>
    public class IQuackObserver : IObservable<IQuackable>
    {
        private List<IObserver<IQuackable>> observers;
        private List<IQuackable> quackables;
        public IQuackObserver()
        {
            observers = new List<IObserver<IQuackable>>();
            quackables = new List<IQuackable>();
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            foreach (var item in quackables)
                observer.OnNext(item);
            return new Unsubscriber<IQuackable>(observers, observer);
        }




        internal class Unsubscriber<IQuackable> : IDisposable
        {
            private List<IObserver<IQuackable>> _observers;
            private IObserver<IQuackable> _observer;

            internal Unsubscriber(List<IObserver<IQuackable>> observers, IObserver<IQuackable> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

    }



    
}
