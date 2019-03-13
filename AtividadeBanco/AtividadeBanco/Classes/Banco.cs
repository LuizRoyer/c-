using AtividadeBanco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
    public class Banco
    {
        private String _nome;
        private int _numero;
        private double _saldo;
        private double _limite;
        private static double _valeRefeicao;


        CartaoCredito _cartao;
        Agencia _agencia;
        Conta conta;
        Emprestimo emprestimo;


        public Banco() { }



        public Banco(string nome, int numero, double saldo, double limite ,Agencia agencia)
        {
            this._nome = nome;
            this._numero = numero;
            this._saldo = saldo;
            this._limite = limite;
            this.Agencia = agencia;

        }

        public  double FazerEmprestimo(Emprestimo emprestimo)
        {
            var valorParcelas = (emprestimo.Valor / emprestimo.Parcelas) * emprestimo.TaxaJuros;

            emprestimo.TotalAPagar = valorParcelas * emprestimo.Parcelas;

            return valorParcelas;

        }



        public double Saldo { get => Saldo1; set => Saldo1 = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public double Saldo1 { get => _saldo; set => _saldo = value; }
        public double Limite { get => _limite; set => _limite = value; }
        internal CartaoCredito Cartao { get => _cartao; set => _cartao = value; }
        internal Agencia Agencia { get => _agencia; set => _agencia = value; }
        internal Conta Conta { get => conta; set => conta = value; }
        public static double ValeRefeicao { get => _valeRefeicao; set => _valeRefeicao = value; }
        internal Emprestimo Emprestimo { get => emprestimo; set => emprestimo = value; }
       
    }

}

