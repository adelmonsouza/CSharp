using System;
using System.Collections;
using System.Linq;
using System.Text;

class Aula21{
     static void Main(){

        //Com o 'DO' eu garanto que pelo menos um comando será executado pelo menos uma vez. Ou seja, ele executa e depois testa.

        string senha="123";
        string senhauser;
        int tentativas=0;

        

        do{
            
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser=Console.ReadLine();
            tentativas++;

        }while(senha !=senhauser);

        Console.Clear();
        Console.WriteLine("Senha Correta! Acertou com tentativas: {0} ", tentativas);
               
    }

}
