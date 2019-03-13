using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco.Classes
{
    public class Telefonista : Funcionario
    {
        private int _estacaoTrabalho;
        Agencia _agencia;

        public Telefonista() { }

        public Telefonista(int estacaoTrabalho, Agencia agencia)
        {
            this._estacaoTrabalho = estacaoTrabalho;
            this._agencia = agencia;
        }



        public int EstacaoTrabalho { get => _estacaoTrabalho; set => _estacaoTrabalho = value; }
        public Agencia Agencia { get => _agencia; set => _agencia = value; }
    }
}
