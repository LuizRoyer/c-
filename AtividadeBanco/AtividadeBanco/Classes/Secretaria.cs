using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco.Classes
{
   public  class Secretaria : Funcionario
    {

        private int _ramal;
        Agencia _agencia;


        public Secretaria() { }

        public Secretaria(int ramal, Agencia agencia)
        {
            this._ramal = ramal;
            this._agencia = agencia;
        }

              


        public int Ramal { get => _ramal; set => _ramal = value; }
    }
}
