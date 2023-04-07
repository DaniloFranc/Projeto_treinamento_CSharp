using System;
     
    class Veiculo{ // Classe base.
        private int rodas;
        public int velMax;
        private bool ligado;

        public Veiculo(int rodas){
            this.rodas=rodas;
        }

        public void ligar(){
            ligado=true;
        }
        public void desligar(){
            ligado=false;
        }
        public string getLigado(){
            return(ligado?"sim":"não");  // operador ternário substitui o if e else abaixo
          // if(ligado){
         //       return "sim";
         //   }else{
         //       return "não";
         //   }    
        }
        public int getRodas(){
            return rodas;
        }
        public void setRodas(int rodas){
            if(rodas<0){
                this.rodas=0;
            }else if(rodas>40){
                this.rodas=40;
            }else{
                this.rodas=rodas;
            }
        }

    }
    class Carro:Veiculo{ // Classe derivada, a subaclasse do veículo tem 4 rodas chama "Carro".
        public string nome;
        public string cor;

        public Carro(string nome, string cor):base(4){  //para criar o metodo construtor na classe derivada 
                                                        //precisamos chamar 
            desligar();                                //o método construto da classe base usando :base(4) 4 rodas.
            velMax=120;
            this.nome=nome;
            this.cor=cor;
            
        }
    }
    class CarroCombate:Carro{ 
        public int municao;
        public CarroCombate():base("Carro de Combate", "Verde"){
            municao=100;
            setRodas(6);
            }
        }
    





    class Aula34{

        static void Main(){
            Carro c1=new Carro("Rapidão","Vermelho"); // aqui ele chama a classe derivada
            CarroCombate cc1=new CarroCombate();
            c1.ligar();
            cc1.ligar();
          //c1.desligar();
            Console.WriteLine("Cor.......:{0}",c1.cor);
            Console.WriteLine("Nome......:{0}",c1.nome);
            Console.WriteLine("Rodas.....:{0}",c1.getRodas());
            Console.WriteLine("Vel.Maxima:{0}",c1.velMax);
            Console.WriteLine("Ligado....:{0}",c1.getLigado());

            Console.WriteLine("------------------------------");

            Console.WriteLine("Cor.......:{0}",cc1.cor);
            Console.WriteLine("Nome......:{0}",cc1.nome);
            Console.WriteLine("Rodas.....:{0}",cc1.getRodas());
            Console.WriteLine("Vel.Maxima:{0}",cc1.velMax);
            Console.WriteLine("Ligado....:{0}",cc1.getLigado());
            Console.WriteLine("Munição....:{0}",cc1.municao);
        }

    }