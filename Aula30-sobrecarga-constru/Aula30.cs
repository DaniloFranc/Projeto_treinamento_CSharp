using System;
class Aula30
{
    
    class Jogador{
        public int energia;
        public bool vivo;
        public string nome;
        // Sobrecarga de métodos construtores - Mesmo nome e conjunto de parâmetros diferentes.
        public Jogador(string n,int e,bool v){
        energia=e;
        vivo=v;
        nome=n;
        }
        public Jogador(string n, int e){
            energia=e;
            vivo=true;
            nome=n;
        }
        public Jogador(){
            energia=100;
            vivo=true;
            nome="Jogador";
        }
        public Jogador(string n){ 
            energia=100;
            vivo=true;
            nome=n;
        }
        public void info(){ // Método da class Jogador.
            Console.WriteLine("Nome jogador...:{0}", nome);
            Console.WriteLine("Energia jogador:{0}", energia);
            Console.WriteLine("Estado jogador.:{0}\n", vivo);
        }
    }
        static void Main(){
            Jogador j1=new Jogador();
            Jogador j2=new Jogador("Bruno");
            Jogador j3=new Jogador("Theo",100);
            Jogador j4=new Jogador("Benegundesfirno",0,false);

            j1.info();
            j2.info();
            j3.info();
            j4.info();
        }
    
}