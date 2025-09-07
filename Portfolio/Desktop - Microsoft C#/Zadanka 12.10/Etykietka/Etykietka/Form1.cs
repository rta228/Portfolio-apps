using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etykietka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textHW.Text = "Hello World!";
        }

        private void buttonEng_Click(object sender, EventArgs e)
        {
            textHW.Text = "Hello World!";
        }

        private void buttonNiem_Click(object sender, EventArgs e)
        {
            textHW.Text = "Hallo Welt!";
        }

        private void buttonHis_Click(object sender, EventArgs e)
        {
            textHW.Text = "Halo Mundo!";
        }

        private void textHW_Click(object sender, EventArgs e)
        {

        }

        private void buttonPL_Click(object sender, EventArgs e)
        {
            textHW.Text = "Witaj Swiecie!";
        }
    }
}
