using PictureBoxy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxy
{ //Zaprojektowac aplikacje ktora pozwoli za pomoca przycisku zmienic jego rozmiar do wartosci naturalnych. 
    //Za pomoca drugiego przycisku wyswietli ona informacje na temat szerokosci i wysokosci obrazka w Label.
    public partial class Form1 : Form
    {
        int x = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flagaBox_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            x+=1;
            if (x > 4) x = 1;
            /*
            switch (x)
            {
                case 1:
                    flagaBox.Image = Image.FromFile("@C:\\Users\\user\\Downloads\\flaga1.jpg");
                    break;

                case 2:
                    flagaBox.Image = Image.FromFile("@C:\\Users\\user\\Downloads\\flaga2.jpg");
                    break;

                case 3:
                    flagaBox.Image = Image.FromFile("@C:\\Users\\user\\Downloads\\flaga3.png");
                    break;

                case 4:
                    flagaBox.Image = Image.FromFile("@C:\\Users\\user\\Downloads\\flaga4.png");
                    break;

                default:
                    break;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
