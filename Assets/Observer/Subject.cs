using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in observers)
            {
                o.OnNotify(this);
            }
        }
    }
}
