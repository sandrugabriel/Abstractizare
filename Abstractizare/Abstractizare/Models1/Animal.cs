using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractizare.Models1
{
    public abstract class Animal
    {
        //Abstracte
        public abstract bool isUnder5Year();
        public abstract int weight();

        //Concrete
        public virtual void afisare()
        {
            Console.WriteLine("Animal");
        }



    }
}
