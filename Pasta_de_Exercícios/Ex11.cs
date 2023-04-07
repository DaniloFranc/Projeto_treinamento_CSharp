using System;

class Pessoa{
    private string nome;
    private int idade;
    private string sexo;

    public Pessoa(string nome, int idade, string sexo){
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
    }

    public void fazerAniversario(){
        this.idade = idade + 1;
    }
}

class Livro{
    private string titulo;
    private string autor;
    private int totPaginas;
    private int pagAtual;
    private bool aberto;
    private Pessoa leitor;

    public Livro(string titulo, string autor, int totPaginas, Pessoa leitor){
        this.titulo = titulo;
        this.autor = autor;
        this.totPaginas = totPaginas;
        this.leitor = leitor;
    }
    public string getTitulo(){
        return titulo;
    }
}

class Ex11{
    static void Main(){

        string a;

        Pessoa p1 = new Pessoa("Danilo", 32, "Masculino");

        Livro l1 = new Livro("1984", "George Orwell", 336, p1);
        
        a = l1.getTitulo();

        Console.WriteLine(a);

    }
}