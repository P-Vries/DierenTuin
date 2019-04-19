using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    class Olifant : Animal
    {
        //
        //Operators
        //
        public Olifant(string name)
        {
            Name = name;
            Energy = 10;
        }

        //
        //Methode
        //
        public override void Eat()
        {
            this.Energy = this.Energy + 50;
        }
        public override void UseEnergy()
        {
            this.Energy = this.Energy - 5;
        }
    }
}
