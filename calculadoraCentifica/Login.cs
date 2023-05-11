using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraCentifica
{
    class Login
    {
        Login logi;
        string valLogin;
        string valSenha;

        public Login() 
        {
            logi = new Login();
        }

        //Método Dados
        public void Dados()
        {
            Console.WriteLine("Digite o Login: ");
            string login = (Console.ReadLine());

            Console.WriteLine("Digite a Senha: ");
            string senha = (Console.ReadLine());
        }//Fim do método Dados

    }
}
