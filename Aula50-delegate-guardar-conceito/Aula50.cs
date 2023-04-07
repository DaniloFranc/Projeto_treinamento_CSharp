using System;

delegate int Op(int n1, int n2); // objeto que faz referência a um método

class Mat{
    public static int soma(int n1, int n2){
        return n1+n2;
    }
    public static int mult(int n1,int n2){
        return n1*n2;
    }
}

class Aula50{
    static void Main(){
        int res;

        Op d1=new Op(Mat.soma); // objeto que faz referência a um método

        res=d1(10,50);
        
        Console.WriteLine("Soma: {0}",res);

        d1=new Op(Mat.mult); // objeto que faz referência a um método

        res=d1(10,50);

        Console.WriteLine("Multiplicação: {0}", res);

    }

}