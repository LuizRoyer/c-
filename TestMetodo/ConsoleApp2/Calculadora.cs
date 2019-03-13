using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculadora
    {
       
        public Decimal Somar( decimal numero1, decimal numero2)
        {
            var soma = numero1 + numero2;
            return soma ;
        }

        public Decimal Subtrair(decimal numero1 , decimal numero2)
        {
            var subtrair = numero1 - numero2;
            return subtrair;

        }
        public Decimal Multiplicar(decimal numero1 , decimal numero2)
        {
            var multiplicar = numero1 * numero2;
            return multiplicar;
        }
        public decimal Dividir(decimal numero1 , decimal numero2)
        {
            var dividir = numero1 / numero2;
            return dividir;
        }

    }
}
