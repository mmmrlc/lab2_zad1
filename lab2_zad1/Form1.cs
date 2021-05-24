using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_zad1
{
    public partial class Form1 : Form
    {
        double wynik;
        double wzrost;
        double Kobieta = 0.85, Mezczyzna = 0.9;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wzrost = Convert.ToDouble(textBox3.Text);
            if ((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    MessageBox.Show("Wybierz tylko jedna wage");
                }
                else if ((radioButton1.Checked == true) && (checkBox1.Checked == true))
                {
                    wynik = (wzrost - 100);
                    label4.Text = Convert.ToString(wynik);
                }
                else if ((radioButton1.Checked == true) && (checkBox2.Checked == true))
                {
                    wynik = (wzrost - 100) * Kobieta;
                    label4.Text = Convert.ToString(wynik);
                }
                else if ((radioButton2.Checked == true) && (checkBox1.Checked == true))
                {
                    wynik = (wzrost - 100);
                    label4.Text = Convert.ToString(wynik);
                }
                else if ((radioButton2.Checked == true) && (checkBox2.Checked == true))
                {
                    wynik = (wzrost - 100) * Mezczyzna;
                    label4.Text = Convert.ToString(wynik);
                }
            }
            else
            {
                MessageBox.Show("Musisz wybrac plec");
            }
        }
    }
}
