using System;

    // a ordem de execução é sempre da classe base para as classes derivadas
    class Base{
        public Base(){
            Console.WriteLine("Construtor da Classe Base");
        }
        virtual public void info(){}        // métodos virtuais são métodos que podem ser sobrescritos.
                                            // para quê ter definição/conteúdo se o método será sobrescrito.
        
    }
    class Derivada1:Base{

        public Derivada1(){
            Console.WriteLine("Construtor da Classe Derivada 1");
        }
        override public void info(){  // método info foi sobrescrito por isso a palavra override.
            Console.WriteLine("Derivada 1");
        }
    }
    class Derivada2:Derivada1{
        public Derivada2(){
            Console.WriteLine("Construtor da Classe Derivada 2");
        }
        override public void info(){  // método info foi sobrescrito por isso a palavra override.
            Console.WriteLine("Derivada 2");
        }
    }
    // a ordem de execução é sempre da classe base para as classes derivadas


    class Aula37{
        static void Main(){
           // Base Ref;
           // Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();

           // derivada2.info;
           // Ref=derivada2;
           // Ref.info();
        }

    }