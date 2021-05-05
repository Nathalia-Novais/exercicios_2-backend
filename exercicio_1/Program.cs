using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool respostaCorreta = false;

             while (respostaCorreta == false)
            {
                Console.WriteLine("Por favor, classifique esse sistema em uma nota de 1 á 10 ");
                int nota = int.Parse(Console.ReadLine());


                if (nota >= 1 && nota <= 10) {
                    Console.WriteLine("obrigada pela sua nota");
                    respostaCorreta = true;
                }else {
                    Console.WriteLine("uma nota de 1 á 10 por favor");
                }

     
                    
                }
        }
    }
}
