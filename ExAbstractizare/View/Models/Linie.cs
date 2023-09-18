using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    public class Linie : IFigura, IDraw
    {
        private string type;
        private string name;
        private Punct punct1;
        private Punct punct2;
        private int id;
        private Color col;
        public Linie(string type, string name,Punct punct1, Punct punct2, int id, Color col)
        {
            this.type = type;
            this.name = name;
            this.punct1 = punct1;
            this.punct2 = punct2;
            this.id = id;
            this.col = col;
        }

        public Linie(string text)
        {
            string[] prop = text.Split(';');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.name = prop[2];
            this.punct1 = new Punct(int.Parse(prop[3]), int.Parse(prop[4]));
            this.punct2 = new Punct(int.Parse(prop[5]), int.Parse(prop[6]));

        }
        public int IdFigura()
        {
            return id;
        }

        public Color culoare()
        {
            return col;
        }

        public Punct Punct1 { get => punct1; set => punct1 = value; }

        public Punct Punct2 { get => punct2; set => punct2 = value; }
        public int Id { get => id; set => id = value; }
        public Color Col { get => col; set => col = value; }

        public void draw(PictureBox pctDesen, Graphics graphics)
        {

            Pen pen = new Pen(col, 1);
            Point point1 = new Point(punct1.X, punct1.Y);
            Point point2 = new Point(punct2.X, punct2.Y);
            graphics.DrawLine(pen, point1, point2);
            pctDesen.Refresh();

        }

        public string Nume()
        {
            return name;
        }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat o line");
        }

        public void translatare(int x1, int y1)
        {
            this.punct1.X += x1;
            this.punct1.Y += y1;
            this.Punct2.X += x1;
            this.Punct2.Y += y1;

            //Console.WriteLine($"S-a translatat liniea");

        }

        public string Type()
        {
            return this.type;
        }

        public void Duplicare()
        {
            Console.WriteLine($"S-a duplicat Liniea");
        }
    }
}
