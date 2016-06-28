using System;
using System.Threading;

namespace Entities
{
    public class PersonDatabase : IPersonDatabase
    {
        public bool Save(string firstName, string lastName, int age)
        {
            // regular code
            Thread.Sleep(1000);
            Random r = new Random();
            if (r.NextDouble() > 0.1)
            {
                Console.WriteLine("Saved successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Errors during save");
                return false;
            }
        }
    }
}