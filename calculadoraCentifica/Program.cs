using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraCentifica
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Login: ");
            string login = (Console.ReadLine());

            Console.WriteLine("Digite a Senha: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer: \n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Média");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro Número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Soma(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 5:
                    {
                        resultado = Potencia(num1, num2);
                        break;
                    }
                case 6:
                    {
                        resultado = Media(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("Número invalído. Digite outro número");
                    break;
            }

            Console.WriteLine("O resultado da Operção  com os números {0} e {1} é: {2}", num1,num2,resultado);

            Console.ReadLine();

        }//Fim do Menu

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

    }//Fim da classe
}//Fim do Projeto
