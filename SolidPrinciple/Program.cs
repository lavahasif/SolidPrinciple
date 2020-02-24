using System;
using SolidPrinciple.SingleResponse;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ObserverPattern();
        }

        static void ObserverPattern()
        {
            var Cricket = new Cricket();
            var user1 = new User1();
            var user2 = new User2();
            Cricket.Subscribe(user1);
            Cricket.Subscribe(user2);
            Cricket.notifyObserver("50");
            Cricket.UnSubscribe(user2);
            Cricket.notifyObserver("100");
        }
    }
}