using System;


    class Ex08{

        class number{
            public int num;
            public number(int n){
                num=n;
            }

            public int Fatorial(){ // aqui tem que ser public int já que a função retorna um número inteiro.
                int fat=1;

                for (int i=1; i<=num; i++){ // aqui tem que ser i<=num.
                    
                    fat=fat*i;

                }
                return fat;
            }



        }

        static void Main(){
            
            int n = 0;
            int a = 0;
            Console.WriteLine("Digite um número para calcular o fatorial: ");
            a = int.Parse(Console.ReadLine());

            number f1=new number(a);

            n = f1.Fatorial(); //a função fatorial tem que estar com o ().

            Console.WriteLine(n);



        }

    }