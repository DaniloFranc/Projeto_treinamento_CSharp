using System;

    class Aula27{

        static void Main(){
            soma(10,5,2,4,7,5,8,6,9);
            soma();
        }

        static void soma(params int[]n){ // argumento params permite vários valores no argumento.
            int res=0;

            if(n.Length < 1){
                Console.WriteLine("Não existe valores a serem somados");
            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para soma: {0}",n[0]);
            }

                for(int i=0; i<n.Length; i++){
                    res+=n[i];
                }
                Console.WriteLine("A soma dos valores é: {0}",res);

        }
        


    }