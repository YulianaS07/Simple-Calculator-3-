using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WseiLab3
{
    public partial class Form1 : Form
    {
        double zmiennaWynik = 0;
        string aktualnaOperacja = "";
        bool nowaLiczba = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "1";
            }
            else
                daneWejsciowe.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "2";
            }
            else
                daneWejsciowe.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "3";
            }
            else
                daneWejsciowe.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "4";
            }
            else
                daneWejsciowe.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "5";
            }
            else
                daneWejsciowe.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "6";
            }
            else
                daneWejsciowe.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "7";
            }
            else
                daneWejsciowe.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "8";
            }
            else
                daneWejsciowe.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "9";
            }
            else
                daneWejsciowe.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += "0";
            }
            else
                daneWejsciowe.Text += "0";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (nowaLiczba)
                daneWejsciowe.Clear();

            nowaLiczba = false;

            if (daneWejsciowe.Text.Contains("+") || daneWejsciowe.Text.Contains("-") || daneWejsciowe.Text.Contains("*") || daneWejsciowe.Text.Contains("/"))
            {
                daneWejsciowe.Clear();
                daneWejsciowe.Text += ",";
            }
            else
                daneWejsciowe.Text += ",";
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            if (zmiennaWynik != 0)
            {
                rowna_sie.PerformClick();
                aktualnaOperacja = "+";
                zmiennaWynik = Double.Parse(wynik.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = dodawanie.Text;
            }
            else
            {
                aktualnaOperacja = "+";
                zmiennaWynik = Double.Parse(daneWejsciowe.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = dodawanie.Text;
            }
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            if (zmiennaWynik != 0)
            {
                rowna_sie.PerformClick();
                aktualnaOperacja = "-";
                zmiennaWynik = Double.Parse(wynik.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = odejmowanie.Text;
            }
            else
            {
                aktualnaOperacja = "-";
                zmiennaWynik = Double.Parse(daneWejsciowe.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = odejmowanie.Text;
            }
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            if (zmiennaWynik != 0)
            {
                rowna_sie.PerformClick();
                aktualnaOperacja = "*";
                zmiennaWynik = Double.Parse(wynik.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = mnozenie.Text;
            }
            else
            {
                aktualnaOperacja = "*";
                zmiennaWynik = Double.Parse(daneWejsciowe.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = mnozenie.Text;
            }
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            if (zmiennaWynik != 0)
            {
                rowna_sie.PerformClick();
                aktualnaOperacja = "/";
                zmiennaWynik = Double.Parse(wynik.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = dzielenie.Text;
            }
            else
            {
                aktualnaOperacja = "/";
                zmiennaWynik = Double.Parse(daneWejsciowe.Text);
                nowaLiczba = true;
                daneWejsciowe.Clear();
                daneWejsciowe.Text = dzielenie.Text;
            }
        }


        private void rowna_sie_Click(object sender, EventArgs e)
        {
            switch (aktualnaOperacja)
            {
                case "+":
                zmiennaWynik += Double.Parse(daneWejsciowe.Text);
                break;
            case "-":
                zmiennaWynik -= Double.Parse(daneWejsciowe.Text);
                break;
            case "*":
                zmiennaWynik *= Double.Parse(daneWejsciowe.Text);
                break;
            case "/":
                if (daneWejsciowe.Text != "0")
                {
                    zmiennaWynik /= Double.Parse(daneWejsciowe.Text);
                    break;
                }
                else
                {
                    MessageBox.Show("Nie można dzielić przez zero!");
                    break;
                }

            }

            wynik.Text = zmiennaWynik.ToString();
            nowaLiczba = true;
            daneWejsciowe.Clear();
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            daneWejsciowe.Clear();
            zmiennaWynik = 0;
            wynik.Text = "0";
            nowaLiczba = true;
        }
    }
}

