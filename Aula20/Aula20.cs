using System;
using System.Collections;
using System.Linq;
using System.Text;

class Aula20{
     static void Main(){


        //While é enquanto

        int[] num =new int [10];

        int i=0; //Variavel de controle da expressao inicializada fora, antes de entrar no loop

        Console.WriteLine("\nInicio do loop:\n");


        while(i<num.Length){ //Usando o tam Length na expressao logica de controle
            num[i]=i;
            Console.WriteLine("Na posicao: {0} NUM tem valor :{1} ",i,num[i]);            
            i++; //Incremento ou decremento da variavel de controle dentro do while. No caso, decremento seria int i=num.Length-1; e o while(i>0){num[i]=0; Console.WriteLine(num[i]); i--;}

        }
        
        Console.WriteLine("\nFim do loop!");
    }

}



/*
        for(int i = 0; i <num.Length; i++){
            num [i] =i; //ou num [i] =i; para que cada posição tenha um valor.
                    
            
        }

        for(int i = 0; i <num.Length; i++){ 
            Console.WriteLine("Valor de num na pos{0}:{1}",i, num[i]);
        }
*/         