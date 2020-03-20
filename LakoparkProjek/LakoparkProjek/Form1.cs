using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakoparkProjek
{
    public partial class Form1 : Form
    {
        private int aktiv;
        private HappyLiving happyLiving;
       
       
        public Form1()
        {
            InitializeComponent();
            this.aktiv = 0;
            happyLiving = new HappyLiving("lakoparkok.txt");


            this.Text = happyLiving.Lakoparkok[aktiv].Nev+"lakópark";
            LakotelepKep.SizeMode = PictureBoxSizeMode.StretchImage;
            if (aktiv == 0)
            {
                balraButton.Visible = false;
            }
            else
            {
                balraButton.Visible = true;
            }
            if (aktiv==happyLiving.Lakoparkok.Count-1)
            {
                jobraButton.Visible = false;
            }
            else
            {
                jobraButton.Visible = true;
            }

            kepPanel.Controls.Clear();
            for (int i = 0; i < happyLiving.Lakoparkok[aktiv].MaxHazSzam; i++)
            {
                for (int j = 0; j < happyLiving.Lakoparkok[aktiv].UtcakSzama; j++)
                {
                    var haz = new PictureBox();
                    if (happyLiving.Lakoparkok[aktiv].Hazak[j,i]==0)
                    {
                        haz.Image = Image.FromFile("kereszt.jpg");
                        
                    }
                    else
                    {
                        haz.Image = Image.FromFile("Haz" + happyLiving.Lakoparkok[aktiv].Hazak[j, i] + ".jpg");
                    }
                    haz.SizeMode = PictureBoxSizeMode.StretchImage;
                    haz.SetBounds(i * 40, j * 40, 40, 40);

                }

            }

        }

        
    }
}
