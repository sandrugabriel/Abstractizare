using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractizare.Models
{
    public class Linie : IFigura, IDraw
    {

        private Punct punct1;
        private Punct punct2;
        private int id;
        public Linie(Punct punct1, Punct punct2, int id)
        {
            this.punct1 = punct1;
            this.punct2 = punct2;
            this.id = id;
        }

        public int IdFigura()
        {
            return id;
        }

        public Punct Punct1 { get => punct1; set => punct1 = value; }

        public Punct Punct2 { get => punct2; set => punct2 = value; }
        public int Id { get => id; set => id = value; }

        public void Draw()
        {
            Console.WriteLine("Liniea a fost desenata");
        }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat o line");
        }

        public void Translatare(int x1, int y1)
        {
            this.punct1.X += x1;
            this.punct1.Y += y1;
            this.Punct2.X += x1;
            this.Punct2.Y += y1;

            Console.WriteLine($"S-a translatat liniea");

        }

        public void Duplicare()
        {
            Console.WriteLine($"S-a duplicat Liniea");
        }
    }
}
