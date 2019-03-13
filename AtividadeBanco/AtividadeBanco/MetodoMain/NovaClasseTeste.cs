using AtividadeBanco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeBanco
{
    class NovaClasseTeste
    {
        static void Main(string[] args)
        {

            Agencia agencia = new Agencia("Agua Branca", "123545692");


            Gerente gerente = new Gerente("JacksonSantos", "123Gerente", agencia);
            gerente.Nome = "Jackson";
            gerente.Salario = 4500.90;
            gerente.ValeRefeicao = Banco.ValeRefeicao;


            Telefonista telefonista = new Telefonista(190, agencia);
            telefonista.Nome = "Maria";
            telefonista.Salario = 2000;
            telefonista.ValeRefeicao = Banco.ValeRefeicao;



            Secretaria secretaria = new Secretaria(33345 - 9988, agencia);
            secretaria.Nome = " Paula ";
            secretaria.Salario = 2000;
            secretaria.ValeRefeicao = Banco.ValeRefeicao;
            secretaria.ReceberBonificacao(150);




            Console.WriteLine(gerente.ReceberBonificacao(0.6));
            Console.WriteLine(telefonista.ReceberBonificacao(100));
            Console.WriteLine(secretaria.ReceberBonificacao(150));



        }

    }
}
