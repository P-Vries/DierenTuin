using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin.Classes
{
    public class Monkey : Animal
    {
        //
        //Constructor
        //
        public Monkey(string name)
        {
            Name = name;
            Energy = 20;
        }

        //
        //Methodes
        //
        public override void Eat()
        {
            this.Energy = this.Energy + 10;
        }
        public override void UseEnergy()
        {
            this.Energy = this.Energy - 2;
        }
    }

}
