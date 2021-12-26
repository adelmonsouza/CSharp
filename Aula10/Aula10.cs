using System;


class Aula10{

   
     enum DiasSemana { Domingo, Segunda, Terça, Quarta,Quinta, Sexta, Sábado};


    static void Main(){


        {
            //DiasSemana ds = (DiasSemana)3; Enumerador a partir da posição 3

            int ds = (int)DiasSemana.Sexta; //Enumerador a partir do dia da semana
            
            Console.WriteLine(ds);
        }

        

        

    }

}