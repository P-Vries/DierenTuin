using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    public abstract class Animal
    {
        //
        //Fields
        //
        private string name;
        private int energy;

        //
        //Constructor
        //
        public Animal()
        {

        }
        
        public Animal(string name, int energy)
        {
            this.name = name;
            this.energy = energy;
        }

        //
        //Properties
        //

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        //
        //Methodes
        //
        public abstract void UseEnergy();
        public abstract void Eat();
    }
}
