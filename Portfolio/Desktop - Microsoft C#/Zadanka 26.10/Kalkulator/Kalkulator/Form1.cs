using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            blad.Text = "Wypelnij wszystkie pola liczbami i wtedy kliknij na wybrane dzialanie";
            znak.Text = "NULL";
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            if (liczba1.Text != "" && liczba2.Text != "")
            {
                double licz1 = double.Parse(liczba1.Text);
                double licz2 = double.Parse(liczba2.Text);

                znak.Text = "+";
                double wyn = (licz1 + licz2);
                wynik.Text = wyn.ToString();
            }
            else
            {
                blad.Text = "Wypelnij wszystkie pola liczbami i wtedy kliknij na wybrane dzialanie";
            }
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            if (liczba1.Text != "" && liczba2.Text != "")
            {
                double licz1 = double.Parse(liczba1.Text);
                double licz2 = double.Parse(liczba2.Text);

                znak.Text = "-";
                double wyn = (licz1 - licz2);
                wynik.Text = wyn.ToString();
            }
            else
            {
                blad.Text = "Wypelnij wszystkie pola liczbami i wtedy kliknij na wybrane dzialanie";
            }
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            if (liczba1.Text!="" && liczba2.Text!="")
            {
                double licz1 = double.Parse(liczba1.Text);
                double licz2 = double.Parse(liczba2.Text);

                znak.Text = "*";
                double wyn = (licz1 * licz2);
                wynik.Text = wyn.ToString();
            }
            else
            {
                blad.Text = "Wypelnij wszystkie pola liczbami i wtedy kliknij na wybrane dzialanie";
            }
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            if (liczba1.Text != "" && liczba2.Text != "")
            {
                double licz1 = double.Parse(liczba1.Text);
                double licz2 = double.Parse(liczba2.Text);

                znak.Text = "/";
                double wyn = (licz1 / licz2);
                wynik.Text = wyn.ToString();
            }
            else
            {
                blad.Text = "Wypelnij wszystkie pola liczbami i wtedy kliknij na wybrane dzialanie";
            }
        }
    }
}
