using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_part2
{
    class Cat : Animal
    {
        //CONSTRUCTOR(S) ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Cat(string name) :
            base (name)
        {
        
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string Speak()
    {
        return this.Name + " says Mome";
    }

        public override void Eats()
        {
            Console.WriteLine("{0} can't eat, because she has a stomach problem", this.Name);
            
        }
       
    }
    
}
