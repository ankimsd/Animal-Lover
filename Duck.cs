using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Lover
{
    class Duck : IAnimal, IBird
    {
        public string _name { get; set; }
        public Duck(string name)
        {
            _name = name;
        }
        public void Eat(string s)
        {
            Console.WriteLine( s);
        }

        public bool Fly()
        {
           Console.WriteLine(_name + " fly");
            return true;
        }

        public void Shout(string s)
        {
            Console.WriteLine(s);
        }

        public bool Swim()
        {
            return true; ;
        }
    }
}
