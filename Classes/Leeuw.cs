using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    sealed class Leeuw : Animal
    {
        //
        //Operators
        //
        public Leeuw(string name)
        {
            Name = name;
            Energy = 10;
        }

        //
        //Methode
        //
        public override void Eat()
        {
            this.Energy = this.Energy + 25;
        }
        public override void UseEnergy()
        {
            this.Energy = this.Energy - 10;
        }
    }
}
