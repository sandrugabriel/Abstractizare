using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Models;

namespace View.Panels
{
    internal class PnlCard : Panel
    {

        private System.Windows.Forms.PictureBox pctDesen;
        private System.Windows.Forms.Label lblNume;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;

        Form1 form;
        DetaliDesen detaliDesen;
        ControllerDetalii controllerDetalii;
        ControllerFigura controllerFigura;
        ControllerClienti controllerClient;

        string path;
        Client client;
        List<int> list;
        public PnlCard(Form1 form1, DetaliDesen detaliDesen1, Client client1)
        {
            form = form1;
            detaliDesen = detaliDesen1;
            controllerClient = new ControllerClienti();
            controllerDetalii = new ControllerDetalii();
            controllerFigura = new ControllerFigura();
            client = client1;
            list = new List<int>();
            path = Application.StartupPath + @"/data/imagini/";

            //PnlCard
            this.BackColor = SystemColors.GradientActiveCaption;
            this.Size = new System.Drawing.Size(332, 254);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PnlCard";

            this.pctDesen = new System.Windows.Forms.PictureBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse();

            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.pctDesen);

            // pctDesen
            this.pctDesen.BackColor = Color.White;
            this.pctDesen.Location = new System.Drawing.Point(12, 12);
            this.pctDesen.Name = "pctDesen";
            this.pctDesen.Size = new System.Drawing.Size(308, 137);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.BackColor = System.Drawing.Color.Transparent;
            this.lblNume.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.ForeColor = Color.Black;
            this.lblNume.Text = detaliDesen.Name;
            this.lblNume.Location = new System.Drawing.Point(this.Width / 2 - (lblNume.Width / 2), 157);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(156, 27);
            this.lblNume.TabIndex = 14;

            // bunifuElipse1
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;

            // bunifuElipse2
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.pctDesen;

            redraw();
        }

        private void ResizeCerc(Cerc shape, float scaleX, float scaleY)
        {
            shape.Punct.X = Convert.ToInt32(shape.Punct.X * scaleX);
            shape.Punct.Y = Convert.ToInt32(shape.Punct.Y * scaleY);
            shape.Radius = Convert.ToInt32(shape.Radius * scaleX);
        }

        private void ResizeLinie(Linie shape, float scaleX, float scaleY)
        {
            shape.Punct1.X = Convert.ToInt32(shape.Punct1.X * scaleX);
            shape.Punct1.Y = Convert.ToInt32(shape.Punct1.Y * scaleY);
            shape.Punct2.X = Convert.ToInt32(shape.Punct2.X * scaleX);
            shape.Punct2.Y = Convert.ToInt32(shape.Punct2.Y * scaleY);
        }

        private void ResizeDrept(Dreptunghi shape, float scaleX, float scaleY)
        {
            shape.Punct.X = Convert.ToInt32(shape.Punct.X * scaleX);
            shape.Punct.Y = Convert.ToInt32(shape.Punct.Y * scaleY);
            shape.Lungime = Convert.ToInt32(shape.Lungime * scaleX);
            shape.Latime = Convert.ToInt32(shape.Latime * scaleY);
        }

        private void redraw()
        {

            float scaleX = (float)pctDesen.Width / (float)1006;
            float scaleY = (float)pctDesen.Height / (float)649;

            List<int> shapes = detaliDesen.IdFiguri;

            List<IFigura> figuras = controllerFigura.getFigures(shapes);

            Bitmap bitmap = new Bitmap(pctDesen.Width, pctDesen.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                foreach (IFigura figura in figuras)
                {
                    if (figura.Type() == "cerc")
                    {
                        Cerc cerc = (Cerc)figura;
                        ResizeCerc(cerc, scaleX, scaleY);
                        g.DrawEllipse(Pens.Black, cerc.Punct.X - cerc.Radius, cerc.Punct.Y - cerc.Radius, 2 * cerc.Radius, 2 * cerc.Radius);
                    }
                    else if (figura.Type() == "linie")
                    {
                        Linie linie = (Linie)figura;
                        ResizeLinie(linie, scaleX, scaleY);
                        g.DrawLine(Pens.Black, linie.Punct1.X, linie.Punct1.Y, linie.Punct2.X, linie.Punct2.Y);
                    }
                    else if (figura.Type() == "dreptunghi")
                    {
                        Dreptunghi dreptunghi = (Dreptunghi)figura;
                        ResizeDrept(dreptunghi, scaleX, scaleY);
                        g.DrawRectangle(Pens.Black, dreptunghi.Punct.X, dreptunghi.Punct.Y, dreptunghi.Lungime, dreptunghi.Latime);
                    }
                }
            }

            pctDesen.Image = bitmap;
        }


    }
}
