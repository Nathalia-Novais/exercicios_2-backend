using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            string nome = "";
            string senha = "";

            while (check == true)
            {
                Console.WriteLine("insira seu nome");
                nome = Console.ReadLine();

                Console.WriteLine("Insira sua senha");
                senha = Console.ReadLine();
                

                if (nome == senha)
                {
                    Console.WriteLine("Cadastro inválido: Nome igual a senha , tente novamente");
                }
                else
                {
                    Console.WriteLine("cadastro efetuado");
                    check = false;
                }
            }
        }
    }
}
