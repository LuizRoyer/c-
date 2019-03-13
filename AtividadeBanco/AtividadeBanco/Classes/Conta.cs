using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
    public class Conta
    {

        private String _numero;
        private double _limite;
        private double _saldo;


        public Conta() { }

        public Conta(string numero, double limite, double saldo)
        {
            _numero = numero;
            _limite = limite;
            _saldo = saldo;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if ((this.Limite + this.Saldo) > valor)
            {
                if (valor > this.Saldo)
                {
                    var valorFaltante = (this.Saldo - valor);
                    this.Saldo = 0;
                    this.Limite = -valorFaltante;

                }
            }
        }

        public String Extrato()
        {

            return "Saldo em Conta R$  " + this.Saldo + " Limite Disponivel R$  " + this.Limite;
        }


        public string Numero { get => _numero; set => _numero = value; }
        public double Limite { get => _limite; set => _limite = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
    }


}
