using System;

namespace SolidPrinciple.SingleResponse
{
    public class User1:Observer
    {
        public void Update(string Score)
        {
            Console.WriteLine("User1:"+Score);
        }
    }
}