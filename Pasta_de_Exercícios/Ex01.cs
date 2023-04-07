using System;

    class Ex01{
        
        static void Main(){
            
            Console.WriteLine("Qual a quantidade máxima no seu estoque? ");
            float max = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade mínima no seu estoque? ");
            float min = float.Parse(Console.ReadLine());

            float med = ((max + min)/2);

            Console.WriteLine("O estoque médio da peça é: {0}", med);

        }


    }