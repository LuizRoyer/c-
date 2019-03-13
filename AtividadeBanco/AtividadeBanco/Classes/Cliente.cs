using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
    public class Cliente
    {
        private String _nome;
        private String _cpf;
        private String _rg;
        Banco _banco;
        CartaoCredito _cartao;
        Conta conta;


        public Cliente() { }

        public Cliente(string nome, string cpc, string rg)
        {
            this._nome = nome;
            this._cpf = cpc;
            this._rg = rg;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public Banco Banco { get => _banco; set => _banco = value; }
        internal CartaoCredito Cartao { get => _cartao; set => _cartao = value; }
        internal Conta Conta { get => conta; set => conta = value; }
    }
}
