using System;


class Aula13{
     static void Main(){

              
        int n1, n2, n3, n4, res = 0;
        res=n1=n2=n3=n4=0;
        string resultado = "Reprovado!";

        Console.Write("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2=int.Parse(Console.ReadLine());
        
        Console.Write("Digite a nota 3: ");
        n3=int.Parse(Console.ReadLine());
        
        Console.Write("Digite a nota 4: ");
        n4=int.Parse(Console.ReadLine());
        
        res= n1+ n2+ n3+ n4;

        //>=60 - Aprovado
        //59 e 40 - Recuperação
        //<40 - Reprovado

        if (res < 40){

            resultado = "Aprovado!"; //O Aluno atingiu a nota maior ou igual 
        
        }else if(res <60){

            resultado = "Recuperação!"; //Deu menor que 60, true. Vai para recuperação
       
        }else{
            resultado = "Reprovado!"; //Caso contrario       
    
        }    
        

        Console.WriteLine("Nota:{0} - Resultado:{1} ", res, resultado);


    }

 }