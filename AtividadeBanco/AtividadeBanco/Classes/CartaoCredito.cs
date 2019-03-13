using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
   public class CartaoCredito
    {
        private String _numero;
        private String _dataDeValidade;
        private Banco _banco;
        private Cliente _cliente;



        public CartaoCredito() { }

        public CartaoCredito(string numero, String dataDeValidade)
        {
            this._numero = numero;
            this._dataDeValidade = dataDeValidade;

        }

        public string Numero { get => _numero; set => _numero = value; }
        public String DataDeValidade { get => _dataDeValidade; set => _dataDeValidade = value; }
        public Banco Banco { get => _banco; set => _banco = value; }
        internal Cliente Cliente { get => _cliente; set => _cliente = value; }
    }
}
