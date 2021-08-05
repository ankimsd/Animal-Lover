using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Lover
{
    public class Dog : IAnimal, IDog
    {
        public String _name;
        public DogType _type;
        public int favourability = 80;
        public Dog (DogType type, int favour, string name)
        {
            this._type = type;
            favourability = favour;
            this._name = name;
        }
        public void Eat(string food)
        {
        }

        public bool Run()
        {
           return true;
        }

        public int CalculaterFavourability( string food)
        {
        //default value
        if (_type == DogType.Chihuahua)
            {
                if (food == "Benovo")
                {
                    favourability = favourability - 30;
                }
                return favourability;
            }
            return 0;

        }

        public void Shout(string s)
        {
            Console.WriteLine(_name + " " +s);
        }

        public void Shout1(string sound, string food)
        {
            // favourability value decides if its for the Dog type olden Retriever or Chihuahua 
            /*if (favourability < 60)//For Chihuahua When the favorability is dropped under 60, it shouts
            {
                Console.WriteLine("shout");
            }
            else
            {

            }*/
            int favour = CalculaterFavourability(food);
                if(favour !=0 && favour < 60)
            {
                Console.WriteLine(sound);
            }
        }
    }
}
