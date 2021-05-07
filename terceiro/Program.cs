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
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Nome inválido");
          Console.ResetColor(); 
           }
           else
           {
             Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("Nome válido");
              check = true;
              Console.ResetColor(); 

          }
         }

            //idade

              while (check == true)
             {
                Console.WriteLine("Qual sua idade?");
             idade = int.Parse(Console.ReadLine());

              if (idade >150)
              {
                 Console.ForegroundColor = ConsoleColor.Red; 
                 Console.WriteLine("idade inválida");
                 Console.ResetColor(); 
               }
              else
              {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("idade válida");
                 check = false; 
                 Console.ResetColor(); 
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
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine("O salário está invalido , coloque um número maior que zero");
                 Console.ResetColor(); 
               }
              else
              {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("salário válido");
                 check = true; 
                 Console.ResetColor(); 
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
            Console.ForegroundColor = ConsoleColor.Green;    
            Console.WriteLine("estado civil válido");
            check = false;
            Console.ResetColor(); 
           }
           else
           {
             Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("estado civíl inválido");
              Console.ResetColor(); 
              }

           
           Console.WriteLine("Dados cadastrados \n" + "nome:" + nome + "\nidade:" + idade + "\nsalário:" + salario + "\nestado civil:" + estadocivil);
      
         }
           

                   

}
}
}
