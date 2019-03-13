using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco.Classes
{
    public class Emprestimo
    {
        private double _valor;
        private double _taxaJuros;
        private int _Parcelas;
        private double _totalAPagar;
        private Cliente _contratante;


        public Emprestimo() { }

        public Emprestimo( double valor, double taxaJuros, int Parcelas ,Cliente contratante)
        {                       
            this._valor = valor;
            this._taxaJuros = taxaJuros;
            this._Parcelas = Parcelas;
            this.Contratante = contratante;
        }

        public double Valor { get => _valor; set => _valor = value; }
        public double TaxaJuros { get => _taxaJuros; set => _taxaJuros = value; }
        public int Parcelas { get => _Parcelas; set => _Parcelas = value; }
        public double TotalAPagar { get => _totalAPagar; set => _totalAPagar = value; }
        internal Cliente Contratante { get => _contratante; set => _contratante = value; }
    }

}
