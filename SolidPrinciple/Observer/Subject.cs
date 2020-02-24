using System;

namespace SolidPrinciple.SingleResponse
{
    public interface Subject
    {
        void Subscribe(Observer observer);
        void UnSubscribe(Observer observer);
        void notifyObserver(String Score);
    }
}