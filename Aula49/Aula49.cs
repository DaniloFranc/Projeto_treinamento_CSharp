using System;

class Mat{
    public static double pi=3.14;
    public static int dobro(int n){
        return n*2;
    }
}


class Aula49{

    static void Main(){
        
        double vpi=Mat.pi;
        
       // Mat m1=new Mat(); // Eu não preciso fazer isso aqui pra poder usar os membros/métodos dele que são static, não preciso declarar o objeto.
        int num=10;

        Console.WriteLine(Mat.dobro(num));
    }
}