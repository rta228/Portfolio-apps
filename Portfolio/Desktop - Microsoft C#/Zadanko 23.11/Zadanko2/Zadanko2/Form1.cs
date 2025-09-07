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

namespace Zadanko2
{
    public partial class Form1 : Form
    {
        //POzwala kopiowac wskazany plik (dysk, sciezka, nazwa pliku (tylko txt)) do miejsca docelowego wskazanego
        //przez dysk, sciezka
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dysk1.Text!=""&& dysk2.Text != "" && sciezka1.Text != "" && sciezka2.Text != "" && nazwaPliku.Text != "")
            {
                string sourceDir = dysk1.Text + ":\\" + sciezka1.Text;
                string backupDir = dysk1.Text + ":\\" + sciezka2.Text;
                string[] txtList = Directory.GetFiles(sourceDir, nazwaPliku.Text+".txt");
                label6.Text= backupDir;
                foreach (string f in txtList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);

                    try
                    {
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }

                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }
            }
            
        }
    }
}
