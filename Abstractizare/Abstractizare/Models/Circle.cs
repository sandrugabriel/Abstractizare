using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractizare.Models
{
    public class Circle : Shape
    {

        private double radius;

        public Circle(double r) { 
            radius = r;
        }

        public override double Aria()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimetrul()
        {
            return 2 * Math.PI * radius;
        }

    }
}
