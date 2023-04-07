using System;

class Ex06{
    static void Main(){
        
        int[] idade = new int[5];
        int id = 0;
        int i = 0;
        int j = 0;
        
        string[] n = new string[5];
        string nome = "";

        for (i = 0; i < idade.Length; i++){

            Console.WriteLine("Digite o nome da Candidata nº {0}: ", i+1);
            nome = Console.ReadLine();
            n[i] = nome;

            Console.WriteLine("Digite a idade da Candidata nº {0}: ", i+1);
            id = int.Parse(Console.ReadLine());
            idade[i] = id;
        }

        Console.WriteLine("As Candidatas aptas a uma vaga na campanha são:");
        for (j = 0; j < n.Length; j++){
            
            if(idade[j] >= 18 && idade[j] <= 20){
                
                Console.WriteLine(n[j]);

            }
        }
    }
}