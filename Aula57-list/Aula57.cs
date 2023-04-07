using System;
using System.Collections.Generic;

class Aula57{

    static void Main(){

        List<string>carros=new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
    
        foreach(string c in carros){
            Console.WriteLine("Carro: {0}", c);
        }    
    }

}