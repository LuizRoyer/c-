using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
   public class Funcionario : Cliente
    {

        private double _salario;
        private double _valeRefeicao;
        private String _dataDeContratacao;
        

        public Funcionario() { }


        public Funcionario(string nome, string cpf, string rg, double salario, String dataComtratacao) : base(nome, cpf, rg)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Salario = salario;
            this._dataDeContratacao = dataComtratacao;

        }

        public void AumentarSalario(double aumento)
        {
            this.Salario += aumento;
        }

        public virtual  double ReceberBonificacao(double bonificacao)
        {
            return this.Salario *= bonificacao;

        }

        public void receberValeAlimentacao(double ValeRefeicao)
        {
            this._valeRefeicao += ValeRefeicao;

        }


        public double Salario { get => _salario; set => _salario = value; }
        public double ValeRefeicao { get => _valeRefeicao; set => _valeRefeicao = value; }
        public string DataDeContratacao { get => _dataDeContratacao; set => _dataDeContratacao = value; }
        
    }
}
