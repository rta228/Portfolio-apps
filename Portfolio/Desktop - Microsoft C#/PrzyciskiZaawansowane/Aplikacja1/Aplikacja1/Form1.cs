using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Zaprojektowac apliakacje ktoea za pomoca 2 przyciskow bedzie wyswietlala obrazkarty
Po lewej stronie bedzie wyswietlany tyl karty po wcisnieciu front jej wyglad pokaze sie po prawej stronie, tyl karty nie bedzie wyswietlony,
po wcisnieciu przycisku back zostaje ukryty front karty, a po przeciwnej stronie wyswietla sie tyl karty.
Aplikacja na poczatku nie wysweitla kart - sa ukryte
*/

namespace Aplikacja1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Front_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
