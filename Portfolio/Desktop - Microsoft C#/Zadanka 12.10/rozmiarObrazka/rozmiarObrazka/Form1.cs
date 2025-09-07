using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rozmiarObrazka
{
    public partial class Form1 : Form
    {
        int x = 0;
        private readonly int hei = Image.FromFile("C:\\Users\\user\\Downloads\\George_Floyd.png").Height;
        private readonly int wid = Image.FromFile("C:\\Users\\user\\Downloads\\George_Floyd.png").Width;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x != 0 && x != 1) {
                x = 0;
            }
            switch (x)
            {
                case 0:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    x = 1;
                    break;

                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    x = 0;

                    pictureBox1.Size = new Size(hei, wid);
                    pictureBox1.Height = hei;
                    pictureBox1.Width = wid;

                    break;

                default:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Wysokosc: " +  pictureBox1.Size.Height.ToString() + "\nSzerokosc: " + pictureBox1.Size.Width.ToString() + "\nTryb: " + pictureBox1.SizeMode.ToString();
        }

    }
}
