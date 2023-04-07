using System; 
class Ex09{

    class Conta{

        private float numero;
        private string titular;
        private float saldo;
        private float limite;

        public Conta(float numero, string titular, float saldo, float limite){
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            this.limite = limite;
            Console.WriteLine("Inicializando uma conta");
        }
        public void deposita(float valor){
            saldo = saldo + valor;                
        }
        public ContaInfo extrato(){
            return new ContaInfo(saldo, titular);
        }

    }

    class ContaInfo {
        public float saldo;
        public string titular;

        public ContaInfo(float saldo, string titular) {
            this.saldo = saldo;
            this.titular = titular;
        }
    }

    static void Main(){

        Conta c = new Conta(46120,"Danilo",300,1000000);

        c.deposita(30);

        ContaInfo info = c.extrato();
        info.titular = "Ju"; // o problema dessa programa é isso... eu não quero alterar o titular fora da classe.

        Console.WriteLine("Titular: {0}", info.titular);
        Console.WriteLine("Saldo: {0}", info.saldo);

    }
}