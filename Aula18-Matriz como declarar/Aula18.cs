using System;

class Aula18 {
   static void Main() {
        int[,] matriz = new int[,] { {1, 0, 0}, {0, 1, 0}, {0, 0, 1} };

        foreach (int numero in matriz) {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }  
}