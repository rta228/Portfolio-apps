using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Grupowanie Obiektow

/*
  Napisz program posiadajacy dwie kontrolgi group box zawierajace 3 pola tesktowe
  W aplikacji mamy dwa zewnetrzne przyciski
  Ich funkcja jest: odblokowanie groupBoxow, gdy mozna do nich wpisywac dane (Imie, nazwisko, miasto).
  Kazde pole tekstowe powinno miec stosownego labela ktory informuje co powinno byc wpisane w polu tekstowym
  Przycisk 2 kopiuje dane do groupBoxa 2 i sprawdza czy groupBox 2 jest odblokowany. 
  W przypadku braku dostepu wyswietlana jest informacja w oknie popUp
 */

namespace Zadanko1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnBlock_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; 
            groupBox2.Enabled = true;
        }

        private void ReWrite_Click(object sender, EventArgs sex)
        {
            if (groupBox1.Enabled == true && groupBox2.Enabled == true)
            {
                MessageBox.Show("Pola sa odblokowane", "Jest git");
            }
            else
            {
                MessageBox.Show("Prosze odblokowac pola aby moc przekopiowac", "Error");
            }
        }

        private void imie1_TextChanged(object sender, EventArgs e)
        {
            imie2.Text = imie1.Text;
        }

        private void nazwisko1_TextChanged(object sender, EventArgs e)
        {
            nazwisko2.Text = nazwisko1.Text;
        }

        private void miasto1_TextChanged(object sender, EventArgs e)
        {
            miasto2.Text = miasto1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dysk.Enabled = true;
        }

        private void dysk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                SaveFileDialog file = new SaveFileDialog();
                file.FileName = dysk.Text+".txt";
                file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                file.ShowDialog();

                using (StreamWriter filewrite = new StreamWriter(file.FileName))
                {
                    filewrite.WriteLine("Imie: "+imie1+" \nNazwisko: "+nazwisko1+"\nMiasto: "+miasto1);
                    //use Write() or WriteLine() again as needed.
                }
            }
        }
    }
}
