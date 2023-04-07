using System;

    class Ex02{

        static void Main(){

            
            int res = 0;
            Console.WriteLine("Digite um número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            int b = int.Parse(Console.ReadLine());
            
            inicio:

            

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
        
            int opcao = int.Parse(Console.ReadLine());
            
            Console.Clear();

            switch(opcao){

                case 1:
                    res = a + b;
                    Console.WriteLine("A Soma de {0} com {1} é {2}",a,b,res);
                    break;
                case 2:
                    res = a - b;
                    Console.WriteLine("A Subtração de {0} com {1} é {2}",a,b,res);
                    break;
                case 3:
                    res = a*b;
                    Console.WriteLine("A Multiplicação de {0} com {1} é {2}",a,b,res);
                    break;
                case 4:
                    Console.WriteLine("A Divisão de {0} com {1} é {2}",a,b,res);
                    res = (a/b);
                    break;             
            }

            Console.WriteLine("Deseja retornar? [s/n] ");
            char o = char.Parse(Console.ReadLine());

            if (o == 'S' || o == 's'){
                goto inicio;
            }
            else{
                Console.WriteLine("Fim do programa!");
            }





            

        }

    }