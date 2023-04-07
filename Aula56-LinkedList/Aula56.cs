using System;
using System.Collections.Generic;

class Aula56{


    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        LinkedListNode<string>no;
        no=transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete");

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);
        }
    }
}