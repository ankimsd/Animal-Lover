using System;

namespace Animal_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Lacey = new Dog(DogType.Chihuahua, 80, "Lacey");
            Lacey.Shout1("wuff", "Benovo");
            //Dog Coco = new Dog(DogType.Golden_Retriever, 80, "Coco");
            //Coco.Eat("Benovo");
            Sparrow Jack = new Sparrow();
            Jack.Shout("chirp");
            Jack.Name("Jack");
            Duck Billie = new Duck("Billie");
            Billie.Fly();
            Console.ReadLine();


        }
    }
}
