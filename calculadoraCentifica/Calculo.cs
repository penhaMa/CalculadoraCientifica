using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraCentifica
{
     class Calculo
    {
        //Método Soma
        public static int Soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }//Fim do método Soma

        //Método Subtração
        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }//Fim do método Subtração

        //Método Divisão
        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }//Fim do método Divisão

        //Método Multiplicação
        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }//Fim do método Multiplicação

        //Método Potência
        public static int Potencia(int num1, int num2)
        {
            int resultado = num1 ^ num2;
            return resultado;
        }//Fim do método Potência

        //Método Média
        public static int Media(int num1, int num2)
        {
            int resultado = (num1 + num2) / 2;
            return resultado;
        }//Fim do método Média

    }
}
