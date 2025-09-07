using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] tab = new int [ 10 ];
        int i = 0;
        int n = 9;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i >= n)
            {
                i = 0;
            }

            tab[0] = int.Parse(textBox1.Text);
            tab[1] = int.Parse(textBox2.Text);
            tab[2] = int.Parse(textBox3.Text);
            tab[3] = int.Parse(textBox4.Text);
            tab[4] = int.Parse(textBox5.Text);
            tab[5] = int.Parse(textBox6.Text);
            tab[6] = int.Parse(textBox7.Text);
            tab[7] = int.Parse(textBox8.Text);
            tab[8] = int.Parse(textBox9.Text);
            tab[9] = int.Parse(textBox10.Text);

            if (tab[i] > tab[i + 1])
            {
                int przech = tab[i];
                tab[i] = tab[i + 1];
                tab[i + 1] = przech;
            }

            textBox1.Text = tab[0].ToString();
            textBox2.Text = tab[1].ToString();
            textBox3.Text = tab[2].ToString();
            textBox4.Text = tab[3].ToString();
            textBox5.Text = tab[4].ToString();
            textBox6.Text = tab[5].ToString();
            textBox7.Text = tab[6].ToString();
            textBox8.Text = tab[7].ToString();
            textBox9.Text = tab[8].ToString();
            textBox10.Text = tab[9].ToString();
            
            i++;
        }
    }
}
