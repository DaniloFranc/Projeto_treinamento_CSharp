using System;
    class Carro{
        private int velMax;
        public int vm{
                    // a propriedade pode ser apenas de Leitura Read Only
            get{    // propriedade de Leitura 
                return velMax;
            }
            set{
                if (value < 0){
                    velMax = 0;
                }
                else if(value > 300)
                {
                    velMax=300;
                }
                else
                {
                    velMax=value;
                }
            }

        }
        public Carro(){
            vm=120;
        }
    }


    class Aula41{
        static void Main(){
            Carro c1 = new Carro();
            
            c1.vm=12; // nesse caso ele usa o "acessor" set
            Console.WriteLine("Velocidade:{0}",c1.vm); // nesse caso ele usa o "acessor" get 
        }
    }