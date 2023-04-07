using System;
using System.Collections.Generic;

class Aula55{
    static void Main(){

        Dictionary <int,string> veiculos = new Dictionary <int,string>(); // modo no C# para declarar um dicionário
        
        int chave=22;

        // atribuindo valores ao dicionário.
        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        
        //veiculos.Clear();
        //veiculos.Remove(20);

        if (veiculos.ContainsKey(chave)){ // retorna se existe um determinado valor, string na coleção.
          //  veiculos.ContainsValue retorna o valor 
            Console.WriteLine("A chave {0} está na coleção",chave);
        }else{
            Console.WriteLine("A chave {0} não está na coleção", chave);
        }

     //   foreach(KeyValuePair<int,string> v in veiculos){
   //         Console.WriteLine(v.Key);
     //   }
        // Ou
        Dictionary<int,string>.ValueCollection valores=veiculos.Values;

        foreach (string v in valores){
            Console.WriteLine(v);
            
        }


    }
}