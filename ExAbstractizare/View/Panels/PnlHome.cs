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
    internal class PnlHome : Panel
    {


        Form1 form;
        Client client;
        ControllerClienti controllerClient;
        ControllerDetalii controllerDetalii;
        ControllerFigura controllerFigura;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox mini;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pctProfile;
        private System.Windows.Forms.Label lblClientNume;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientPanel;

        private string path;

        PnlToateCardurile toateCardurile;

        public PnlHome(Form1 form1, Client client1)
        {

            form = form1;
            this.client = client1;
            controllerClient = new ControllerClienti();
            controllerDetalii = new ControllerDetalii();
            controllerFigura = new ControllerFigura();
            path = Application.StartupPath + @"/data/imagini/";

            this.form.Size = new System.Drawing.Size(1479, 749);
            this.form.Location = new Point(35, 35);

            //PnlHome
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Size = new System.Drawing.Size(1479, 749);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PnlHome";

            this.btnAdd = new System.Windows.Forms.Button();
            this.mini = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pctProfile = new System.Windows.Forms.PictureBox();
            this.lblClientNume = new System.Windows.Forms.Label();
            this.gradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();

            this.Controls.Add(this.gradientPanel);

            // btnAdd
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = Image.FromFile(path + "gallery.png");
            this.btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 60);
            this.btnAdd.BackColor = Color.Transparent;
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Text = "      Add";
            this.btnAdd.Click += new EventHandler(btnAdd_Click);

            // mini
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Image = Image.FromFile(path + "mini.png");
            this.mini.Location = new System.Drawing.Point(1391, 34);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(28, 29);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini.Click += new EventHandler(mini_Click);

            // close
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = Image.FromFile(path + "close.png");
            this.close.Location = new System.Drawing.Point(1439, 33);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.Click += new EventHandler(close_Click);

            // pctProfile
            this.pctProfile.BackColor = System.Drawing.Color.Transparent;
            this.pctProfile.Location = new System.Drawing.Point(1171, 17);
            this.pctProfile.Name = "pctProfile";
            this.pctProfile.Size = new System.Drawing.Size(68, 59);
            this.pctProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // lblClientNume
            this.lblClientNume.AutoSize = true;
            this.lblClientNume.BackColor = System.Drawing.Color.Transparent;
            this.lblClientNume.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNume.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClientNume.Location = new System.Drawing.Point(1257, 33);
            this.lblClientNume.Name = "lblClientNume";
            this.lblClientNume.Size = new System.Drawing.Size(82, 27);
            this.lblClientNume.Text = client.Name;

            // gradientPanel
            this.gradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel.Controls.Add(this.lblClientNume);
            this.gradientPanel.Controls.Add(this.pctProfile);
            this.gradientPanel.Controls.Add(this.close);
            this.gradientPanel.Controls.Add(this.mini);
            this.gradientPanel.Controls.Add(this.btnAdd);
            this.gradientPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel.GradientBottomLeft = System.Drawing.Color.LightSlateGray;
            this.gradientPanel.GradientBottomRight = System.Drawing.Color.Lavender;
            this.gradientPanel.GradientTopLeft = System.Drawing.Color.Silver;
            this.gradientPanel.GradientTopRight = System.Drawing.SystemColors.ButtonShadow;
            this.gradientPanel.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel.Name = "gradientPanel";
            this.gradientPanel.Quality = 10;
            this.gradientPanel.Size = new System.Drawing.Size(1479, 97);

            List<DetaliDesen> detaliDesens = controllerDetalii.getDesene();
            toateCardurile = new PnlToateCardurile(form, detaliDesens, client);

            this.Controls.Add(toateCardurile);
            toateCardurile.Location = new Point(3, 97);

            toateCardurile.Size = new Size(1467, 640);
            // toateCardurile.BackColor = Color.Gray;
        }
        public void removePnlHome(string pnl)
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

        private void close_Click(object sender, EventArgs e)
        {
            this.form.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.form.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlHome");
            this.form.Controls.Add(new PnlAdd(form, client));

        }


    }
}
