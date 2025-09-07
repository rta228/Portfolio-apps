using RockPaperScisors.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace RockPaperScisors
{
    public partial class Form1 : Form
    {
        int wynPlayer;
        int wynComputer;
        int coinsPlayer;
        int coinsComputer;
        int roundAmo;
        int number;
        public Form1()
        {
            InitializeComponent(); 
            wynPlayer = 0;
            wynComputer = 0;
        }

        int RandComp()
        {
            Random rnd = new Random();
            int opponentPoz = rnd.Next(1, 4);
            switch (opponentPoz)
            {
                case 1:
                    opponent.Image = Properties.Resources.rock;
                    break;
                case 2:
                    opponent.Image = Properties.Resources.paper;
                    break;
                case 3:
                    opponent.Image = Properties.Resources.scisors;
                    break;
            }
            return opponentPoz;
            //1-kamien 1-1=Tie, 1-2=Lose, 1-3=Win
            //2-papier  2-2=Tie, 2-3=Lose, 2-1=Win
            //3-nozyczki  3-3=Tie, 3-1=Lose, 3-2=Win
        }

        void Diffoto(int ni)
        {
            switch (ni)
            {
                case 1:
                    player.Image = Properties.Resources.rock;
                    break;
                case 2:
                    player.Image = Properties.Resources.paper;
                    break;
                case 3:
                    player.Image = Properties.Resources.scisors;
                    break;
            }
        }

        void Graj(int playerPoz)
        {
            Diffoto(playerPoz);
            if (playerPoz==RandComp())
            {
                Outcome(2);
            }
            else if (playerPoz- RandComp()==1 || playerPoz - RandComp() == -2)
            {
                Outcome(1);
            }
            else
            {
                Outcome(0);
            }
        }

        int whoWillBet(int who)
        {
            int value; 
            Random rnd = new Random();
            value = rnd.Next(1, 10);
            zakladComp.Text = value.ToString();
            switch (who)
            {
                case 0:
                    return value;
                case 1:
                    if (zaklad.Text=="")
                    {
                        return value;
                    }
                    value = int.Parse(zaklad.Text);
                    return value;
                case 2:
                    if (value<=int.Parse(zaklad.Text))
                    {
                        value = int.Parse(zaklad.Text);
                        return value;
                    }
                    return value;
                default:
                    return value;
            }
        }

        void gambling(int wyn)
        {
            if (wyn == 1)
            {
                coinsPlayer += whoWillBet(wyn);
                coinsComputer -= whoWillBet(wyn);
            }
            else
            {
                coinsPlayer -= whoWillBet(wyn);
                coinsComputer += whoWillBet(wyn);
            }
            changeCoinsValue();
        }

        int WynikChecker(int wynik, int roundAmo)
        {
            if (wynik>=3)
            {
                rockPB.Enabled = false;
                paperPB.Enabled = false;
                scisorsPB.Enabled = false;
                return 1;
            }
            return 0;
        }

        void Outcome(int otcPoz)
        {
            if (WynikChecker(wynComputer, roundAmo) !=0 || WynikChecker(wynPlayer, roundAmo) != 0)
            {
                label1.Text = "Koniec gry!";
                roundCount.Enabled = true;
            }
            else
            {
                switch (otcPoz)
                {
                    case 0:
                        gambling(0);
                        wynComputer += 1;
                        wynOpp.Text = wynComputer.ToString();
                        outcome.Text = "Lose";
                        outcome.ForeColor = Color.Red;
                        break;
                    case 1:
                        gambling(1);
                        wynPlayer += 1;
                        wynPla.Text = wynPlayer.ToString();
                        outcome.Text = "Win";
                        outcome.ForeColor = Color.Green;
                        break;
                    case 2:
                        outcome.Text = "Tie";
                        outcome.ForeColor = Color.Yellow;
                        break;
                }
            }
        }

        void Reset()
        {
            rockPB.Enabled = false;
            paperPB.Enabled = false;
            scisorsPB.Enabled = false;
            roundCount.Enabled = true;
            wynComputer = 0;
            wynOpp.Text = wynComputer.ToString();
            wynPlayer = 0;
            wynPla.Text = wynPlayer.ToString();
            outcome.Text = "Play";
            outcome.ForeColor = Color.Black;
            label1.Text = "Rock Paper Scisors";
        }

        void changeCoinsValue()
        {
            if (coinsPlayer<=0 || coinsComputer<=0)
            {
                rockPB.Enabled = false;
                paperPB.Enabled = false;
                scisorsPB.Enabled = false;
                reset.Enabled = false;
                wynPla.Visible = false; 
                wynOpp.Visible = false;
                outcome.Text = "GAME OVER";
            }
            playerCoins.Text = coinsPlayer.ToString();
            computerCoins.Text = coinsComputer.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coinsComputer = 100;
            coinsPlayer = 100;
            changeCoinsValue();
        }

        private void rock_Click(object sender, EventArgs e)
        {
            Graj(1);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Graj(2);
        }

        private void scisors_Click(object sender, EventArgs e)
        {
            Graj(3);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void opponent_Click(object sender, EventArgs e)
        {

        }

        private void zaklad_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundCount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(roundCount.Text, out number))
            {
                roundAmo = int.Parse(roundCount.Text);
                rockPB.Enabled = true;
                paperPB.Enabled = true;
                scisorsPB.Enabled = true;
                roundCount.Enabled = false;
            }
        }
    }
}
