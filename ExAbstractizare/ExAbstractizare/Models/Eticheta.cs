using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractizare.Models
{
    internal class Eticheta : Dreptunghi,IFigura,IDraw
    {

        private string text;
        public Eticheta(string text, int lungime, int latime, Punct punct, int id) : base(lungime, latime, punct, id)
        {
            this.text = text;
        }


        public string Text { get => text; set => text = value; }

        public void Draw()
        {
            Console.WriteLine("Dreptunghiul cu textul sa desenat");
        }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat un dreptunghi cu textul {text}");
        }

        public void Translatare(int x, int y)
        {
            this.Punct.X += x;
            this.Punct.Y += y;

            Console.WriteLine("S-a translatat dreptunghiul cu textul");
        }

        public void Duplicare()
        {
            Console.WriteLine("S-a duplicat dreptunghiul cu textul");
        }

    }
}
