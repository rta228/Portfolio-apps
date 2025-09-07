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

namespace Zadanko1
{ //Na podstawei wprowadzonych danych (naped, sciezka, rozszerzenie pliku)
  //wyswietlic info o ilosci dostepnych w miejscu przeznaczenia plikow (Wyswietli nazwy tych plikow)
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (naped.Text != ""){
                textBox1.Text = ("");
                textBox2.Text = ("");
               DirectoryInfo di = new DirectoryInfo(naped.Text + ":\\" + sciezka.Text);
                DirectoryInfo[] diArr = di.GetDirectories();
                foreach (DirectoryInfo dri in diArr)
                    textBox2.Text += (dri.Name + Environment.NewLine);

                foreach (var fi in di.GetFiles("*" + rozszerzenie.Text))
                    textBox1.Text += (fi.Name + Environment.NewLine);
            }
            
        }
    }
}
