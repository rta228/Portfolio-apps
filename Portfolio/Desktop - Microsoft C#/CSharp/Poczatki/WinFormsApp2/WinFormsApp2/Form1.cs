namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // Zaprojektowac aplikacje ktora przy pomocy 2 buttonow stworzy w polu statycznym tekst Hello World
        //Zaprojektowac aplikacje, ktora przy pomocy przycisku buttona zmieni tekst tytulu w formatce
        // Zaprojektowac aplikacje ktora posiada dwa buttony reagujace na zdarzenie mouseMove. Zdarzenie to uzupelnia etykiete tworzac hello world 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += " World";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Text = "Tytul";
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Nie odejdziesz", "Prawda");
            this.Text = "Odejdz!";
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "";
            label2.Text += "Hello";

        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "";
            label2.Text += " World";
        }
    }
}