using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){

        string[] vs={"Carro","Moto","Navio","Avião"};

        Queue<string>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v="Patinete";
        if (veiculos.Contains(v)){
            Console.WriteLine("Veiculos "+v+" encontrado");
        }else{
            Console.WriteLine("Veiculo "+v+" não está na fila");
        }
        Console.WriteLine("Primeiro Veiculo "+ veiculos.Dequeue());
        Console.WriteLine("Primeiro Veiculo "+ veiculos.Dequeue());
        Console.WriteLine("Primeiro Veiculo "+ veiculos.Peek());
        /*
        foreach(string veic in veiculos){
            Console.WriteLine("Veiculo " + veic);
        } */
        Console.WriteLine("Tamanho fila: "+veiculos.Count);

        while(veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho da fila: "+ veiculos.Count);
    }
}
