using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractizare.Models
{
    public class Dreptunghi:IFigura,IDraw
    {
        private Punct punct;
        private int lungime, latime;
        private int id;
        public Dreptunghi(int lungime, int latime, Punct punct, int id)
        {
            this.lungime = lungime;
            this.latime = latime;
            this.punct = punct;
            this.id = id;
        }

        public int IdFigura()
        {
            return id;
        }

        public int Lungime { get => lungime; set => lungime = value; } 

        public int Latime { get => latime; set => latime = value; }
        public Punct Punct { get => punct; set => punct = value; }
        public int Id { get => id; set => id = value; }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat un dreptunghi\nLungimea:{lungime}\nLatime:{latime}\nPunctul: x={punct.X}.y={punct.Y}");
        }

        public void Draw()
        {
            Console.WriteLine("Dreptunghiul s-a desenat");
        }

        public void Translatare(int x,int y)
        {
            this.punct.X += x;
            this.punct.Y += y;

            Console.WriteLine($"Dreptunghul s-a translatat la x={this.punct.X}, y={this.punct.Y}");
        }

        public void Duplicare()
        {
            Console.WriteLine("Dreptunghiul s-a duplicat");
        }

    }
}
