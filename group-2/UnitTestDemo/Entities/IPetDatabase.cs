using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IPetDatabase
    {
        bool SaveNewPet(string name, int age);
    }
}
