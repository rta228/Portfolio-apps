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

namespace Cezar
{
    public partial class Form1 : Form
    {
        private int parsedValue;
        private char[] tablica = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'q', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void szyfruj_Click(object sender, EventArgs e)
        {
            if (tekstDoZakodowania.Text != "" && !int.TryParse(tekstDoZakodowania.Text, out parsedValue) && klucz.Text!="" && int.TryParse(klucz.Text, out parsedValue))
            {
                string tek = tekstDoZakodowania.Text;
                int klu = int.Parse(klucz.Text);
                char[] tabWynik= new char[tek.Length];
                if (klu >= 0 && klu < 26)
                {
                    for (int i = 0; i < tek.Length; i++)
                    {
                        char litera = tek[i];
                        if (tek[i] == ' ' || tek[i] == '\n') continue;
                        int pozycja = Array.IndexOf(tablica, litera);
                        int nowaPozycja = (pozycja + klu) % 26;
                        char literaZaszyfrowana = tablica[nowaPozycja];
                        tabWynik[i] = literaZaszyfrowana;
                    }
                    wynikSzyfru.Text = string.Join("", tabWynik);
                }
                else
                {
                    blad.Text = "Podaj klucz bedacy w granicach <0;26>";
                }
            }
            else
            {
                blad.Text = "Podaj odpowiednie wartosci";
            }
        }
    }
}
