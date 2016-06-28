using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person("Wekoslav", "Stefanovski", 0x26);
            Console.WriteLine($"{weko.FirstName} {weko.LastName} ({weko.Age})");

            weko.Database = new PersonDatabase();
            weko.SaveToDatabase();
        }
    }
}
