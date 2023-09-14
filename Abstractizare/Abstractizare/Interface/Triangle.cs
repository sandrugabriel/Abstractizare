using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractizare.Interface
{
    public class Triangle : IShape,IDrawable
    {

        public double Inaltime { get; set; }
        
        public double Latura { get; set; }

        public Triangle(double inaltime, double latura)
        {
            Inaltime = inaltime;
            Latura = latura;
        }

        public double CalculateArea()
        {
            return Inaltime * Latura / 2;
        }

        public void Display()
        {
            Console.WriteLine("Triangle");
        }

        public void draw()
        {
            Console.WriteLine("Draw triangle");
        }

    }
}
