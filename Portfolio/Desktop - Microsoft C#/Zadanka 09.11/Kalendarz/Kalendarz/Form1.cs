using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendarz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] MonthNames = { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
        string[] DayNames = {"poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela"};
        private string ToRomanNumber(int number)
        {
            StringBuilder result = new StringBuilder();
            int[] digitsValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] romanDigits = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            while (number > 0)
            {
                for (int i = digitsValues.Count() - 1; i >= 0; i--)
                    if (number / digitsValues[i] >= 1)
                    {
                        number -= digitsValues[i];
                        result.Append(romanDigits[i]);
                        break;
                    }
            }
            return result.ToString();
        }

        private string ToPolishDays(string dayAng)
        {
            if (dayAng == "Monday") return DayNames[0].ToString();
            else if (dayAng == "Tuesday") return DayNames[1].ToString();
            else if (dayAng == "Wednesday") return DayNames[2].ToString();
            else if (dayAng == "Thursday") return DayNames[3].ToString();
            else if (dayAng == "Friday") return DayNames[4].ToString();
            else if (dayAng == "Saturday") return DayNames[5].ToString();
            else if (dayAng == "Sunday") return DayNames[6].ToString();
            else return "BLAD";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int yearVal = int.Parse(monthCalendar1.SelectionRange.Start.Year.ToString());
            int monthVal = int.Parse(monthCalendar1.SelectionRange.Start.Month.ToString());
            string dayVal = monthCalendar1.SelectionRange.Start.DayOfWeek.ToString();
            day.Text = ToPolishDays(dayVal);
            month.Text = MonthNames[monthVal-1];
            year.Text = ToRomanNumber(yearVal);
        }
    }
}
