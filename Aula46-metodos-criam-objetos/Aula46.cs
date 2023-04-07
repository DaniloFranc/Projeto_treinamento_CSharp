using System;

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        this.numOvo=0; // se eu colocar this. em todas as variáveis como numOvo igual o Python, funciona também.
    }
    public Ovo botar(){ // método que cria um objeto Ovo.
        this.numOvo = this.numOvo + 1;  // ou.. numOvo++
        return new Ovo(this.numOvo, this.nomeGalinha); // cria o objeto.
    }
}

class Ovo{      

    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo=numOvo;
        this.minhaGalinha=minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}",this.numOvo,this.minhaGalinha);
    }
}


class Aula46{
    
    static void Main(){
        Galinha g1=new Galinha("Beneditasgildimar");
        Galinha g2=new Galinha("Felizbertaniazilda");
        Galinha g3=new Galinha("Marisgertrudeszela");

        g1.botar();
        g1.botar();
        g1.botar();
       

        g2.botar();

        g3.botar();
        g3.botar();
    }
}