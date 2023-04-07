using System;

    class Aula28{

        public class Jogador{

            public int energia;
            public bool vivo = true;
            public string nome;
            public Jogador(string n){ // Método Construtor
                energia = 100;
                vivo = true;
                nome=n;
            }   
            ~Jogador(){ // Método Destrutor
                Console.WriteLine("Jogador {0} foi destruido", nome);
            }
           

        }


        static void Main(){

            Jogador j1=new Jogador("bRUNO");
            
            string n = j1.nome;
           
            Console.WriteLine(n);

        }



    }