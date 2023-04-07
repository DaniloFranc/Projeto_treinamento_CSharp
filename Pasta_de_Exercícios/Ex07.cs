using System;

class Ex07 {
    static void Main() {
        int[] vetor01 = new int[5];
        int[] vetor02 = new int[5];
        int cont = 0;
        vetor01[0] = 12; 
        vetor01[1] = 11; 
        vetor01[2] = 5; 
        vetor01[3] = 120; 
        vetor01[4] = 15;

        vetor02[0] = 120; 
        vetor02[1] = 11; 
        vetor02[2] = 56;
        vetor02[3] = 12; 
        vetor02[4] = 15;

        for(int i=0; i < vetor01.Length; i++){
            
            bool encontrado = false;

            for(int j = 0; j< vetor01.Length; j++){ 
                if (vetor01[i] == vetor02[j] && !encontrado){
                    Console.WriteLine("Os vetores possuem valores iguais na posição {0} no (vetor 1) e na posição {1} no (vetor 2), e valor {2}", i, j, vetor01[i]);
                    cont = cont + 1;
                    encontrado = true;
                }
            }
        }
        Console.WriteLine("Os valores se repetem {0} vezes", cont);
    }
}