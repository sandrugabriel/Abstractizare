using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractizare.Models
{
    internal class Cerc : IFigura, IDraw
    {

        private int radius;
        private Punct punct;
        private int id;
        public Cerc(int radius, Punct punct, int id)
        {
            this.radius = radius;
            this.punct = punct;
            this.id = id;
        }

        public int IdFigura()
        {
            return id;
        }

        public int Radius { get => radius; set => radius = value; }

        public Punct Punct { get => punct; set => punct = value; }
        public int Id { get => id; set => id = value; }

        public void Draw()
        {
            Console.WriteLine("Cercul este desenat");
        }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat un cerc\nRaza:{radius}\nPunctul: x={punct.X},y={punct.Y}");
        }

        public void Translatare(int x, int y)
        {
            this.punct.X += x;
            this.punct.Y += y;

            Console.WriteLine($"S-a translatat cercul la x={punct.X},y={punct.Y}");
        }

        public void Duplicare()
        {
            Console.WriteLine("S-a duplicat cercul");
        }

    }
}
