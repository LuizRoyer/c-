using AtividadeBanco.Classes;
using System;

namespace AtividadeBanco
{
    class Program 
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia("Testo salto", "00001");

            CartaoCredito cartaoCredito = new CartaoCredito("0001-3333-444-111", "19 / 09 / 2080");

            Conta conta = new Conta("876999", 500, 1000);

            Banco banco = new Banco("Visao", 11111, 1000, 500, agencia);
            Banco.ValeRefeicao = 230.99;
            banco.Cartao = cartaoCredito;

            
            Cliente cliente = new Cliente("Pedro", "094.488;999-99", "0.141.712");
            cliente.Banco = banco;
            cliente.Cartao = cartaoCredito;
            cliente.Conta = conta;
            cliente.Conta.Sacar(1200);


            cartaoCredito.Cliente = cliente;
            cartaoCredito.Banco = banco;


            Funcionario funcionario = new Funcionario("Adamastor", "111111", "777777", 1000.50, "04/09/1995");
            funcionario.receberValeAlimentacao(Banco.ValeRefeicao);
            funcionario.receberValeAlimentacao(Banco.ValeRefeicao);


            Funcionario funcionario1 = new Funcionario("Roberto", "4455323", "***82233288xx", 1500, "19/04/2007");
            funcionario1.ValeRefeicao = Banco.ValeRefeicao;


            Emprestimo emprestimo = new Emprestimo(18000.00, 1.66, 48, funcionario1);
            var ParcelaDoInprestimo = banco.FazerEmprestimo(emprestimo);

            Emprestimo emprestimo1 = new Emprestimo(28000, 1.96, 48, funcionario);
            var ParcelaDoInprestimo1 = banco.FazerEmprestimo(emprestimo1);



            Console.WriteLine("Nome do  Banco " + banco.Cartao.Banco.Nome);
            Console.WriteLine("Local da Agencia " + banco.Agencia.Nome);
            Console.WriteLine("Numero do Cartao " + banco.Cartao.Numero);
            Console.WriteLine("Proprietario do Cartao " + banco.Cartao.Cliente.Nome);
            Console.WriteLine("Conta " + cliente.Conta.Numero);
            Console.WriteLine(conta.Extrato());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Funcionario " + funcionario.Nome);
            Console.WriteLine("Salario " + funcionario.Salario);
            Console.WriteLine("Vale Alimentacao " + funcionario.ValeRefeicao);
            Console.WriteLine("Data Admissao " + funcionario.DataDeContratacao);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Funcionario " + funcionario1.Nome);
            Console.WriteLine("Salario " + funcionario1.Salario);
            Console.WriteLine("Vale Alimentacao " + funcionario1.ValeRefeicao);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Solicitante do Emprestimo " + emprestimo.Contratante.Nome);
            Console.WriteLine("Valor das parcelas  " + ParcelaDoInprestimo);
            Console.WriteLine("Valor  Financiado " + emprestimo.Valor);
            Console.WriteLine("Valor Total Financiado " + emprestimo.TotalAPagar);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Solicitante do Emprestimo " + emprestimo1.Contratante.Nome);
            Console.WriteLine("Valor das parcelas  " + ParcelaDoInprestimo1);
            Console.WriteLine("Valor  Financiado " + emprestimo1.Valor);
            Console.WriteLine("Valor Total Financiado " + emprestimo1.TotalAPagar);

            Console.WriteLine();
            Console.WriteLine();





            Console.ReadKey();

        }
    }
}
