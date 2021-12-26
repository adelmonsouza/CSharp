using System;
using System.Collections;
using System.Linq;
using System.Text;

class Aula19{
     static void Main(){


        //Comando de interação For

        int[] num =new int [10];

        for(int i = 0; i <num.Length; i++){
            num [i] =i; //ou num [i] =i; para que cada posição tenha um valor.
                    
            
        }

        for(int i = 0; i <num.Length; i++){ 
            Console.WriteLine("Valor de num na pos{0}:{1}",i, num[i]);
        }
         
         

    }

}