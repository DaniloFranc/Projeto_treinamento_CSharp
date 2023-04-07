using System;

    class Ex09{

        class Banco{
            private string nome;

            public Banco(string nome){ // Classe construtora de Banco classe principal-Base.
                this.nome=nome;
            }
        }



        class Conta:Banco{ // Conta é a Classe derivada de Banco.

            private float numero;
            private string titular;
            private float saldo;
            private float limite;
            public float s{
                    
                get{    
                    return saldo;
                }   
                
                set{
                    saldo=value;
                }
            }
            public Conta(float numero, string titular, float saldo, float limite):base("Banco do Brasil"){
                this.numero = numero;
                this.titular = titular;
                this.saldo = saldo;
                this.limite = limite;
                Console.WriteLine("Inicializando uma conta");
            }
            
        
            public void deposita(float valor){
                saldo = saldo + valor;                
            }
            private void extratoConta(){
                Console.WriteLine("Seu saldo é de: {0}",saldo);
            }
            private void extratoTitular(){
                Console.WriteLine("Titular da conta: {0}",titular);
            }
            public void extrato(){
                extratoConta();
                extratoTitular();
            }
        }  
    




        static void Main(){
          
            Conta c = new Conta(46120,"Danilo",300,1000000);
            
          
            c.deposita(30);
            
            c.extrato();  
            c.s = 5000;     
          //  Console.WriteLine(c.s);
            c.extrato();
            

        }




    }