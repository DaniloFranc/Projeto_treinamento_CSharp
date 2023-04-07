using System;
    public interface Veiculo{
        void ligar();
        void desligar();
        void info();

    }
    public interface Combate{
        void disparar();
    }
    class Carro:Veiculo,Combate{ // aqui ele usa a interface combate e a interface veículo.
        public bool ligado;
        private int municao;
        public Carro(){
            this.municao=100;
        }
        public void setMunicao(int qtde){
            this.municao=qtde;
        }
        public void disparar(){}
        public void ligar(){
            this.ligado=true;
        }
        public void desligar(){
            this.ligado=false;
        }
        public void info(){}

    }


    class Aula43{

        static void Main(){

        }
    }