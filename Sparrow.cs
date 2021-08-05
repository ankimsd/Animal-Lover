using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Lover
{
    class Sparrow : IAnimal, IBird
    {
        public void Eat(string s)
        {
            Console.WriteLine(s);
        }

        public void Name(string name)
        {
            Console.WriteLine(name);
        }

        public bool Fly()
        {
            return true;
        }

        public void Shout(string s)
        {
            Console.WriteLine(s);
        }

    }
}
