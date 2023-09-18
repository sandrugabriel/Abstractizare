﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Models;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Client client = new Client("1;gabi;gabi1234");
            this.Controls.Add(new Panels.PnlHome(this,client));
        }
        
        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }


    }
}
