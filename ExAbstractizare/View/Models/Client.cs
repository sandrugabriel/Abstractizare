﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Models
{
    internal class Client
    {

        private int id;
        private string name;
        private string password;

        public Client(int id, string name, string password)
        {
            Id = id;
            this.name = name;
            this.password = password;
        }

        public Client(string text)
        {
            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.password = prop[2];

        }

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }

        public string Password { get => password; set => password = value; }

        public string tosave()
        {
            string t = Id.ToString() + ";" + Name.ToString() + ";" + Password.ToString() + ";";
           
            return t;
        }


    }
}
