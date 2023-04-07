using System;

abstract class Veiculo{ // classe base abstrata
// classe abstrata serve como base para outras classes que vão herdar.
// não posso instanciar um objeto de uma classe abstrata.
// se eu crio métodos que não são abstratos eu preciso implementar a funcionalidade do método.
// se eu crio métodos abstratos esses métodos não podem ter implementação. 
// métodos abstratos servem só para dizer que a classe derivada obrigatóriamente precisa implementar esse método.

    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado){
        this.ligado=ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMaxima=120;
    }
    override public void aceleracao(int mult){
        velAtual = velAtual + 10*mult; 
    }
}

class Aula39{

    static void Main(){

        Carro carro1 = new Carro();
        carro1.aceleracao(1);
        Console.WriteLine(carro1.getVelAtual());
    }
}