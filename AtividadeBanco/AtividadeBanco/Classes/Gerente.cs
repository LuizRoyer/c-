namespace AtividadeBanco.Classes
{
    public class Gerente : Funcionario
    {

        private string _nomeAcesso;
        private string _senhaAcesso;
        Agencia _agencia;

        public Gerente() { }

        public Gerente(string nomeAcesso, string senhaAcesso, Agencia agencia)
        {
            this._nomeAcesso = nomeAcesso;
            this._senhaAcesso = senhaAcesso;
            this._agencia = agencia;
        }

        public override double ReceberBonificacao(double bonificacao)
        {
           var extra = this.Salario *= bonificacao ;

            return extra + 50;
        }


        public string NomeAcesso { get => _nomeAcesso; set => _nomeAcesso = value; }
        public string SenhaAcesso { get => _senhaAcesso; set => _senhaAcesso = value; }
        public Agencia Agencia { get => _agencia; set => _agencia = value; }
    }
}
