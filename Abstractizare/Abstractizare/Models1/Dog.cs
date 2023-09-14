using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractizare.Models1
{
    public class Dog : Animal
    {

        private bool under5Year;
        private int greutate;

        public Dog(bool isUnder5Year, int weight) {

            this.under5Year = isUnder5Year;
            this.greutate = weight;
        }

        public override bool isUnder5Year()
        {
            return under5Year;
        }

        public override int weight()
        {
            return greutate;
        }

    }
}
