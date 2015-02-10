using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson6_part2
{
    abstract class Animal
    {
        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;

        //PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string Name
        {
            get
            {
                return this._name;// Read-Only
            }
        }
        public Animal(string name)
        {
            this._name = name;
        }

        // ABSTRACT METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public abstract string Speak();

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++
        public virtual void Runs()
        {
            Console.WriteLine("{0} is running", this._name);
        }

        public virtual void Eats()
        {
            Console.WriteLine("{0} is eating", this._name);
        }
    }
}
