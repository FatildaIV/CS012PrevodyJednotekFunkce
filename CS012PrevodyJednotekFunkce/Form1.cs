using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS012PrevodyJednotekFunkce
{
    public partial class PrevodyJednotekFunkceForm : Form
    {
        private string HodnotaJednotka; // proměnná pro uložení hodnoty jednotky v textboxu

        public PrevodyJednotekFunkceForm()
        {
            InitializeComponent();
        }

        private void PrevodyJednotekFunkceForm_Load(object sender, EventArgs e)
        {

        }

        private double Celsius(double value, string unit)
        {
            switch (unit)
            {
                case "°F" : return (((value - 32) / 9) * 5);
            }
            throw new NotImplementedException(
                string.Format("Program není kompatibilní s převodem jednotek {0}.", unit));
        }

        private double Fahrenheit(double value, string unit)
        {
            if (unit == "°C") return ((value / 5 * 9) + 32);
            throw new NotImplementedException(string.Format("Program není kompatibilní s převodem jednotek {0}.", unit));
        }

        private void JednotkyComboBox_TextChanged(object sender, EventArgs e)
        {
            if (HodnotaTextBox.Text != "")
            {
                if(JednotkaComboBox.Text == "°C")
                {
                    HodnotaTextBox.Text = Celsius(Double.Parse(HodnotaTextBox.Text), JednotkaComboBox.Text).ToString();
                }
            }
        }

        private void HodnotaTextBox_Enter(object sender, EventArgs e)
        {
            HodnotaJednotka = JednotkaComboBox.Text;
        }
    }
}
