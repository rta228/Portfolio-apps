namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Zaprojektuj aplikacje ktora wyswietli 3 pola statyczne o tlach czerwony, zielony i niebieski i tekstach w kolorze bialym.
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Zaproszenie", "Hello");
            label1.Text = "Wes se mnie kliknij a ja ci powiem kim jestes";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jestes", "Pedofilem");
            label1.Text = "Stuu";
        }
    }
}