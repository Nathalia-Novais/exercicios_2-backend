using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)
        {

             int anterior = 0;
             int proximo = 1;
             int contador;

            for (var i = 0; i < 14; i ++)
            {
                 contador = anterior + proximo;
                 anterior = proximo;
                 proximo = contador;
                 Console.WriteLine(contador);
            }
        }
    }
}
