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
    public class Dreptunghi:IFigura,IDraw
    {
        private Punct punct;
        private int lungime, latime;
        private int id;
        private Color col;
        private string nume, type;
        public Dreptunghi(string type, string nume,int lungime, int latime, Punct punct, int id, Color col)
        {
            this.type = type;
            this.nume = nume;
            this.lungime = lungime;
            this.latime = latime;
            this.punct = punct;
            this.id = id;
            this.col = col;
        }

        public Dreptunghi(string text)
        {
            string[] prop = text.Split(';');

            this.type = prop[0];
            this.id = int.Parse(prop[1]);
            this.nume = prop[2];
            this.punct = new Punct(int.Parse(prop[3]), int.Parse(prop[4]));
            this.lungime = int.Parse(prop[5]);
            this.latime = int.Parse(prop[6]);

        }

        public string Type()
        {
            return this.type;
        }

        public int IdFigura()
        {
            return id;
        }

        public Color culoare()
        {
            return col;
        }

        public string Nume()
        {
            return nume;
        }

        public int Lungime { get => lungime; set => lungime = value; } 

        public int Latime { get => latime; set => latime = value; }
        public Punct Punct { get => punct; set => punct = value; }
        public int Id { get => id; set => id = value; }
        public Color Col { get => col; set => col = value; }

        public void Afisare()
        {
            Console.WriteLine($"S-a afisat un dreptunghi\nLungimea:{lungime}\nLatime:{latime}\nPunctul: x={punct.X}.y={punct.Y}");
        }


        public void draw(PictureBox pctDesen, Graphics graphics)
        {

            Pen pen = new Pen(col, 1);
            graphics.DrawRectangle(pen, punct.X, punct.Y, lungime, latime);
            pctDesen.Refresh();
        }


        public void translatare(int x,int y)
        {
            this.punct.X += x;
            this.punct.Y += y;

         //   Console.WriteLine($"Dreptunghul s-a translatat la x={this.punct.X}, y={this.punct.Y}");
        }

        public void Duplicare()
        {
            Console.WriteLine("Dreptunghiul s-a duplicat");
        }

    }
}
