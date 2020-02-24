using System.Collections.Generic;

namespace SolidPrinciple.SingleResponse
{
    public class Cricket : Subject
    {
        List<Observer> arraylist = new List<Observer>();

        public void Subscribe(Observer observer)
        {
            arraylist.Add(observer);
        }

        public void UnSubscribe(Observer observer)
        {
            arraylist.Remove(observer);
        }

        public void notifyObserver(string Score)
        {
            arraylist.ForEach(observer => observer.Update(Score));
        }
    }
}