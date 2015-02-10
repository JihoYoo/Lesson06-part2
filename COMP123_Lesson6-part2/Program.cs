using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string catSpeak;
            string dogSpeak;

            Cat myCat = new Cat("Tiger");
            catSpeak = myCat.Speak();
            Console.WriteLine(catSpeak);
            myCat.Runs();
            myCat.Eats();

            Dog myDog = new Dog("Conan");
            dogSpeak = myDog.Speak();
            Console.WriteLine(dogSpeak);
            myDog.Runs();
            myDog.Eats();

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
