using System;

    class Ex05{

        static void Main(){

            Console.WriteLine("Números que deseja processar? ");
            
            int N = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            int fat = 1;
            
           
           for (i=1; i<=N; i++){

                Console.WriteLine("Digite o {0} número desejado: ",i);
                int num = int.Parse(Console.ReadLine());
                
                for(j = 1; j <= num; j++){

                    fat = fat*j;
                
                }
                

            Console.WriteLine("O fatorial de {0} é {1}",num,fat);
            fat = 1; 
                
            }

            
            



        }
    
    }
