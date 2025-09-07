using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kolory
{
    public partial class Form1 : Form
    {
        private int parsedValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (red.Text!=""&& green.Text != "" && blue.Text != "" && int.TryParse(red.Text, out parsedValue) && int.TryParse(green.Text, out parsedValue) && int.TryParse(blue.Text, out parsedValue))
            {
                int redVal = int.Parse(red.Text);
                int greenVal = int.Parse(green.Text);
                int blueVal = int.Parse(blue.Text);
                if (redVal <= 255 && redVal >=0 && greenVal <= 255 && greenVal >= 0 && blueVal <= 255 && blueVal >= 0)
                {
                    Color kolor = Color.FromArgb(redVal, greenVal, blueVal);
                    this.BackColor = kolor;
                }
                else
                {
                    blad.Text = "Podaj poprawne wartosci w kazdej z tabelek (wieksze lub rowne 0 i mniejsze od 256";
                }
            }
            else
            {
                blad.Text = "Podaj poprawne wartosci w kazdej z tabelek (wieksze lub rowne 0 i mniejsze od 256";
            }
            
        }
    }
}
