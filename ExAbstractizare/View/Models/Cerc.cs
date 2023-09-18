using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Models
{
    internal class Cerc : IFigura, IDraw
    {

        private int radius;
        private Punct punct;
        private int id;
        private string nume, type;
        private Color col;
        public Cerc(string type, string nume,int radius, Punct punct, int id, Color col)
        {
            this.type = type;
            this.nume = nume;
            this.radius = radius;
            this.punct = punct;
            this.id = id;
            this.col = col;
        }


        public Cerc(string text)
        {

            string[] prop = text.Split(';');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.nume = prop[2];
            this.radius = int.Parse(prop[3]);
            this.punct = new Punct(int.Parse(prop[4]), int.Parse(prop[5]));

        }

        public int IdFigura()
        {
            return id;
        }

        public Color culoare()
        {
            return col;
        }

        public int Radius { get => radius; set => radius = value; }

        public Punct Punct { get => punct; set => punct = value; }
        public int Id { get => id; set => id = value; }
        public Color Col { get => col; set => col = value; }

        public string Nume()
        {
            return nume;
        }

        public void draw(PictureBox pctDesen, Graphics graphics)
        {

            // MessageBox.Show(x + "  " + y + "  " + raza);
            Pen pen = new Pen(col, 1);
            graphics.DrawEllipse(pen, punct.X - radius, punct.Y - radius, 2 * radius, 2 * radius);
            pctDesen.Refresh();
        }


        public string Type()
        {
            return this.type;
        }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat un cerc\nRaza:{radius}\nPunctul: x={punct.X},y={punct.Y}");
        }

        public void translatare(int x, int y)
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
