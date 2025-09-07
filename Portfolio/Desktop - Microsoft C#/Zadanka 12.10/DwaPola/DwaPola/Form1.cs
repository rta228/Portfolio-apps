using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DwaPola
{
    public partial class Form1 : Form
    {
        Image Image1 = Image.FromFile("C:\\Users\\user\\Downloads\\George_Floyd.png");
        Image Image2 = Image.FromFile("C:\\Users\\user\\Downloads\\Floyd_George.jpg");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image1;
            pictureBox2.Image = Image2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    Image right = pictureBox1.Image;
                    Image left = pictureBox2.Image;
                    pictureBox1.Image= left;
                    pictureBox2.Image= right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image right = pictureBox1.Image;
            Image left = pictureBox2.Image;
            pictureBox1.Image = left;
            pictureBox2.Image = right;

        }
    }
}
