﻿using System;
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
        private string nume, type;
        public Cerc(string type, string nume,int radius, Punct punct, int id)
        {
            this.type = type;
            this.nume = nume;
            this.radius = radius;
            this.punct = punct;
            this.id = id;
        }

        public int IdFigura()
        {
            return id;
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
