using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_part2
{
    class Dog : Animal
    {
        //CONSTRUCTOR(S) ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Dog(string name) : 
            base (name)
        {
        
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string Speak()
    {
         return this.Name + " says woof";
    }
        public override void Runs()
        {
            Console.WriteLine("{0} is lame and can't run", this.Name);
        }
       
    }
    
}
