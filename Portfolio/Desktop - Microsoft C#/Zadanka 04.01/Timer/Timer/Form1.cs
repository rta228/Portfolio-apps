using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
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
        bool seter = false;
        int hoursAlarm=0;
        int minutesAlarm = 0;
        int secondsAlarm = 0;
        int hPosition1, mPosition1, sPosition1, hPosition2, mPosition2, sPosition2;


        void digitalNumbers()
        {
            DateTime dateTime = DateTime.Now;
            string hour = dateTime.Hour.ToString();
            string minute = dateTime.Minute.ToString();
            string second = dateTime.Second.ToString();

            if (dateTime.Second > 10)
            {
                sPosition1 = int.Parse(second.Substring(0, 1));
                sPosition2 = int.Parse(second.Substring(1, 1));
            }
            if (dateTime.Minute > 10)
            {
                mPosition1 = int.Parse(minute.Substring(0, 1));
                mPosition2 = int.Parse(minute.Substring(1, 1));
            }
            if (dateTime.Hour > 10)
            {
                hPosition1 = int.Parse(hour.Substring(0, 1));
                hPosition2 = int.Parse(hour.Substring(1, 1));
            }
            else if (dateTime.Second < 10 || dateTime.Minute < 10 || dateTime.Hour < 10)
            {
                hPosition1 = 0;
                sPosition2 = int.Parse(second); 
                
                mPosition1 = 0;
                mPosition2 = int.Parse(minute);

                sPosition1 = 0;
                hPosition2 = int.Parse(hour);
            }

            changePhoto(hourPic1, hPosition1);
            changePhoto(hourPic2, hPosition2);

            changePhoto(minutePic1, mPosition1);
            changePhoto(minutePic2, mPosition2);

            changePhoto(secondPic1, sPosition1);
            changePhoto(secondPic2, sPosition2);

        }

        void changePhoto(PictureBox pos, int val)
        {
            switch (val)
            {
                case 0:
                    pos.Image = Properties.Resources._0;
                    break;
                case 1:
                    pos.Image = Properties.Resources._1;
                    break;
                case 2:
                    pos.Image = Properties.Resources._2;
                    break;
                case 3:
                    pos.Image = Properties.Resources._3;
                    break;
                case 4:
                    pos.Image = Properties.Resources._4;
                    break;
                case 5:
                    pos.Image = Properties.Resources._5;
                    break;
                case 6:
                    pos.Image = Properties.Resources._6;
                    break;
                case 7:
                    pos.Image = Properties.Resources._7;
                    break;
                case 8:
                    pos.Image = Properties.Resources._8;
                    break;
                case 9:
                    pos.Image = Properties.Resources._9;
                    break;
                default:
                    pos.Image = Properties.Resources._0;
                    break;
            }
            
        }

        void changeColor(int second, int caseVal)
        {
            switch (caseVal){
                case 1:
                    label1.ForeColor = Color.Green;
                    label2.BackColor = Color.LightCoral;
                    label3.BackColor = Color.LightCoral;
                    label4.BackColor = Color.LightCoral;
                    label5.BackColor = Color.LightCoral;
                    label6.BackColor = Color.LightCoral;
                    if (second % 2 == 0)
                    {
                        label2.BackColor = Color.LightCyan;
                        label3.BackColor = Color.LightCyan;
                        label4.BackColor = Color.LightCyan;
                        label5.BackColor = Color.LightCyan;
                        label6.BackColor = Color.LightCyan;
                        label1.ForeColor = Color.Red;
                    }
                    break;

                case 2:
                    label1.ForeColor = Color.Green;
                    if (second % 2 == 0)
                    {
                        label1.ForeColor = Color.Red;
                    }
                    break;
            }
        }
        void Czasomierz(int value)
        {
            if(value==1)
            {
                TimerScript(1);
            }
            else if (value == 2)
            {
                TimerScript(2);
            }
        }

        void TimerScript(int val)
        {
            DateTime dateTime = DateTime.Now;
            changeColor(dateTime.Second, val);
            if (dateTime.Second < 10)
            {
                label1.Text = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":0" + dateTime.Second.ToString();
            }
            else if (dateTime.Minute < 10)
            {
                label1.Text = dateTime.Hour.ToString() + ":0" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString();
            }
            else if (dateTime.Hour < 10)
            {
                label1.Text = "0"+dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString();
            }
            else
            {
                label1.Text = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString() + ":" + dateTime.Second.ToString();
            }
        }

        bool checkData(int dataToCheck, int type)
        {
            switch (type)
            {
                case 1:
                    if (dataToCheck > 24 || dataToCheck < 0)
                    {
                        return false;
                    }
                    return true;
                case 2:
                    if (dataToCheck > 60 || dataToCheck < 0)
                    {
                        return false;
                    }
                    return true;
            } return true;
        }

        void SetBudzik()
        {
            if (!checkData(int.Parse(godziny.Value.ToString()), 1) || !checkData(int.Parse(minuty.Value.ToString()), 2) || !checkData(int.Parse(sekundy.Value.ToString()), 2))
            {
                MessageBox.Show("Godziny moga wynosic maksymalnie 24, a minuty i sekundy 60","ERROR");
            }
            else
            {
                seter = true;
                hoursAlarm = int.Parse(godziny.Value.ToString());
                minutesAlarm = int.Parse(minuty.Value.ToString());
                secondsAlarm = int.Parse(sekundy.Value.ToString());
                if (secondsAlarm<10) label3.Text = hoursAlarm.ToString() + ":" + minutesAlarm.ToString() + ":0" + secondsAlarm.ToString();
                else if (minutesAlarm < 10) label3.Text = hoursAlarm.ToString() + ":0" + minutesAlarm.ToString() + ":" + secondsAlarm.ToString();
                else if (hoursAlarm < 10) label3.Text = "0"+hoursAlarm.ToString() + ":" + minutesAlarm.ToString() + ":" + secondsAlarm.ToString();
                else label3.Text= hoursAlarm.ToString() + ":" + minutesAlarm.ToString() + ":" + secondsAlarm.ToString();
            }
        }

        void Budzik(int hoursAlarm, int minutesAlarm, int secondsAlarm)
        {
            Czasomierz(1);
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour == hoursAlarm && dateTime.Minute == minutesAlarm && dateTime.Second == secondsAlarm)
            {
                seter = false;
                MessageBox.Show("Budzik dzwoni. Dryyynnnn!", "Alarm!");
                label2.BackColor = Color.Transparent;
                label3.BackColor = Color.Transparent;
                label4.BackColor = Color.Transparent;
                label5.BackColor = Color.Transparent;
                label6.BackColor = Color.Transparent;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seter)
            {
                Czasomierz(1);
                Budzik(hoursAlarm, minutesAlarm, secondsAlarm);
                digitalNumbers();
            }
            digitalNumbers();
            Czasomierz(2);
        }
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void setAlarm_Click(object sender, EventArgs e)
        {
            SetBudzik();
        }
    }
}
