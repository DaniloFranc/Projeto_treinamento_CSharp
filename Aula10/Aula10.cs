using System;

class Aula10{

    enum DiasSemana{Domingo,Segunda,Terça,Querta,Quinta,Sexta,Sábado};

    static void Main()
    {
        DiasSemana ds = DiasSemana.Domingo; 
        DiasSemana da = (DiasSemana)4;
        Console.WriteLine(ds);
        Console.WriteLine(da);
        
        
        Console.ReadLine();



    }


}