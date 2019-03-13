using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
    public class Agencia
    {
        private String _nome;
        private String _numero;
        private Banco _banco;
        Funcionario _Funcionario;

        public Agencia() { }


        public Agencia(string nome, string numero)
        {
            _nome = nome;
            _numero = numero;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public Banco Banco { get => _banco; set => _banco = value; }
        public Funcionario Funcionario { get => _Funcionario; set => _Funcionario = value; }
    }
}
