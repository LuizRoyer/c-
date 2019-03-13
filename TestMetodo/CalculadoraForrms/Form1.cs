using ConsoleApp2;
using System;

using System.Windows.Forms;

namespace CalculadoraForrms
{
    public partial class Form1 : Form
    {
        Calculadora calculadora = new Calculadora();
        Decimal numero1 = 0, numero2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtPrimeironumero.Text) && !String.IsNullOrEmpty(txtSegundoNumero.Text ))
                {

                    numero1 = Convert.ToDecimal(txtPrimeironumero.Text);
                    numero2 = Convert.ToDecimal(txtSegundoNumero.Text);

                    if (numero1 == 0 || numero2 == 0)
                    {
                        MessageBox.Show("Informe um numero Diferente de Zero");

                    }
                    else
                    {
                        lbResultado.Text = Convert.ToString(calculadora.Subtrair(numero1, numero2));
                    }

                }
                else
                {
                    MessageBox.Show("Verifique Algum Campo Vazio ");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("So Aceitamos numeros");
                txtPrimeironumero.Text = String.Empty;
                txtSegundoNumero.Text = String.Empty;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtPrimeironumero.Text) && !String.IsNullOrEmpty(txtSegundoNumero.Text))
                {

                    numero1 = Convert.ToDecimal(txtPrimeironumero.Text);
                    numero2 = Convert.ToDecimal(txtSegundoNumero.Text);

                    if (numero1 == 0 || numero2 == 0)
                    {
                        MessageBox.Show("Informe um numero Diferente de Zero");

                    }
                    else
                    {
                        lbResultado.Text = Convert.ToString(calculadora.Multiplicar(numero1, numero2));
                    }

                }
                else
                {
                    MessageBox.Show("Verifique Algum Campo Vazio ");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("So Aceitamos numeros");
                txtPrimeironumero.Text = String.Empty ;
                txtSegundoNumero.Text = String.Empty;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtPrimeironumero.Text) && !String.IsNullOrEmpty(txtSegundoNumero.Text ))
                {

                    numero1 = Convert.ToDecimal(txtPrimeironumero.Text);
                    numero2 = Convert.ToDecimal(txtSegundoNumero.Text);

                    if (numero1 == 0 || numero2 == 0)
                    {
                        MessageBox.Show("Informe um numero Diferente de Zero");

                    }
                    else
                    {
                        lbResultado.Text = Convert.ToString(calculadora.Dividir(numero1, numero2));
                    }

                }
                else
                {
                    MessageBox.Show("Verifique Algum Campo Vazio ");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("So Aceitamos numeros");
                txtPrimeironumero.Text = String.Empty;
                txtSegundoNumero.Text = String.Empty;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrimeironumero.Text = String.Empty;
            txtSegundoNumero.Text = String.Empty;
            lbResultado.Text = String.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            try
            {
                if (!String.IsNullOrEmpty(txtPrimeironumero.Text) && !String.IsNullOrEmpty(txtSegundoNumero.Text))
                {

                    numero1 = Convert.ToDecimal(txtPrimeironumero.Text);
                    numero2 = Convert.ToDecimal(txtSegundoNumero.Text);

                    if (numero1 == 0 || numero2 == 0)
                    {
                        MessageBox.Show("Informe um numero Diferente de Zero");

                    }
                    else
                    {
                        lbResultado.Text = Convert.ToString(calculadora.Somar(numero1, numero2));
                    }

                }
                else
                {
                    MessageBox.Show("Verifique Algum Campo Vazio ");
                }



            }
            catch (Exception)
            {
                MessageBox.Show("So Aceitamos numeros");
                txtPrimeironumero.Text = String.Empty;
                txtSegundoNumero.Text = String.Empty;
            }
        }


    }
}
