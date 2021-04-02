using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1"; 
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "/";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "x";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "-";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "+";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string cadena = txtResultado.Text;
            if (cadena.Contains("+"))
            {
                string[] numeros;
                numeros = cadena.Split("+");
                Sumar(numeros);
            }
            else
            {
                if (cadena.Contains("-"))
                {
                    string[] numeros;
                    numeros = cadena.Split("-");
                    Restar(numeros);
                }
                else
                {
                    if (cadena.Contains("x"))
                    {
                        string[] numeros;
                        numeros = cadena.Split("x");
                        Multiplicar(numeros);
                    }
                    else
                    {
                        if (cadena.Contains("/"))
                        {
                            string[] numeros;
                            numeros = cadena.Split("/");
                            Dividir(numeros);
                        }
                    }

                }
            }
        }
        public void Sumar(string[] numeros)
        {
            double suma = 0;
            for(int i = 0; i< numeros.Length; i ++)
            {
                suma += double.Parse(numeros[i]);
            }
            txtResultado.Text = Convert.ToString(suma);
        }

        public void Restar(string[] numeros)
        {
            double resta = double.Parse(numeros[0]);
            for (int i =1; i< numeros.Length; i++)
            {
                resta -= double.Parse(numeros[i]);
            }
            txtResultado.Text = Convert.ToString(resta);
        }

        public void Multiplicar(string[] numeros)
        {
            double multiplicacion = 1;
            for (int i = 0; i < numeros.Length; i++)
            {
                multiplicacion *= double.Parse(numeros[i]);
            }
            multiplicacion = Math.Round(multiplicacion, 2);
            txtResultado.Text = Convert.ToString(multiplicacion);
        }

        public void Dividir(string[] numeros)
        {
            double division = double.Parse(numeros[0]);
            for(int i = 1; i < numeros.Length; i++)
            {
                division /= double.Parse(numeros[i]);
            }
            division = Math.Round(division, 2);

            txtResultado.Text = Convert.ToString(division);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El resultado de la operacion es {txtResultado.Text}");
        }
    }
}
