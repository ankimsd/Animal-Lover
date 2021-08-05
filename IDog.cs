using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Lover
{
    interface IDog : IAnimal
    {
        public bool Run();
    }
}
