using System;

namespace terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bool check = false;
            string nome = "";
            int idade = 0;
            float salario = 0;
            string estadocivil = "";
            string salario0 ="";

             while ( check == false)
         {
           Console.WriteLine("Insira seu nome");
           nome = Console.ReadLine();

           if (nome == "")
          {
          Console.WriteLine("Nome inválido");
           }
           else
           {
              Console.WriteLine("Nome válido");
               check = true;

          }
         }

            //idade

              while (check == true)
             {
                Console.WriteLine("Qual sua idade?");
             idade = int.Parse(Console.ReadLine());

              if (idade >150)
              {
                Console.WriteLine("idade inválida");
               }
              else
              {
                  Console.WriteLine("idade válida");
                 check = false; 
                 }      
             }

             //salario


               while (check == false)
             {
                Console.WriteLine("Qual é o seu salário?");
                salario0 =(Console.ReadLine());

                if (salario0 == ""){
                   
                    salario0 = "0";
                }

               salario = float.Parse(salario0);
            
              if (salario <= 0)
              {
                Console.WriteLine("O salário está invalido , coloque um número maior que zero");
               }
              else
              {
                  Console.WriteLine("salário válido");
                 check = true; 
                 }      
             }


           //estado civil

                while ( check == true)
         {
           Console.WriteLine("Qual é o seu estado civil? " );
           Console.WriteLine ("'S' (solteiro(a))  'C'(casado(a))  'V' (viuvo(a))  'D' (divorciado(a)) "); 
           estadocivil = Console.ReadLine().ToUpper();

           if (estadocivil == "S" || estadocivil == "C" || estadocivil == "V" || estadocivil == "D" )
          {
          Console.WriteLine("estado civil válido");
          check = false;
           }
           else
           {
              Console.WriteLine("estado civíl inválido");
   }
         }
           

                   

}
}
}
