﻿using System;
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

        /// <summary>
        /// Realiza a divisão conforme parâmetros passados para o metodo
        /// </summary>
        /// <param name="numero1">Número a ser dividido</param>
        /// <param name="numero2">Número divisor</param>
        /// <returns>Resultado do calculo no tipo decimal</returns>
        public decimal Dividir(decimal numero1 , decimal numero2)
        {
            var dividir = numero1 / numero2;
            return dividir;
        }

    }
}
