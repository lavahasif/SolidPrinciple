using System;

namespace SolidPrinciple.SingleResponse
{
    public class User2:Observer
    {
        public void Update(string Score)
        {
            Console.WriteLine("User2:"+Score);
        }
    }
}