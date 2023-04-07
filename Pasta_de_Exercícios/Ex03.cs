using System;

    class Ex03{

        static void Main(){


            Console.WriteLine("Digite o seu sexo [m/f]: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            float h = float.Parse(Console.ReadLine());
            float ideal = 0;
            

            switch(sexo){

                case 'm':
                case 'M':
                ideal = (72.7f*h) - 58f;
                Console.WriteLine("O peso ideal para homens é {0}.",ideal);
                break;

                case 'f':
                case 'F':
                ideal = (62.1f*h) - 44.7f;
                Console.WriteLine("O peso ideal para mulheres é {0}.",ideal);
                break;

        }



    }

}