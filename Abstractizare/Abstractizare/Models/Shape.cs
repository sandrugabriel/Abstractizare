using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractizare.Models
{
    //orice clasa concreta ce mosteneste o clasa abstracta este OBLIGATA sa suprascrie metodele abstracte ale bazei
    //Daca o clasa abstracta  constine doar metode abstracte atunci ar fi bine sa folosim o interfata
    public abstract class Shape
    {

        public abstract double Aria();
        public abstract double Perimetrul();

    }
}
