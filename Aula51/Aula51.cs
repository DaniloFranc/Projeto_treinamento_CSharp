using System;


class Aula51{

    static void Main(string[] args){
        if(args.Length > 0){
            Console.WriteLine("Qtde de argumentos {0}", args.Length);
            for(int i=0; i< args.Length; i++){
                Console.WriteLine("Argumentos {0}:{1}", i, args[i]);
            }
        }
        else{
            Console.WriteLine("Não foram passados argumentos");
        }

    }
}