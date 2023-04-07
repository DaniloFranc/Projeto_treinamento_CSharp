using System;

    class Aula26{

        static void Main(){
            int divid,divis,quoc,rest;
            divid=50;
            divis=5;
            
            quoc=divide(divid,divis,out rest);

            Console.WriteLine("{0}/{1}: quociente={2} e resto={3}",divid,divis,quoc,rest);

        }
        
        // pode se colocar vários argumentos com out fazendo o método retornar vários valores.
        static int divide(int dividendo, int divisor, out int resto){ // argumento out permite retornar mais de um valor no Método.
            int quociente; 
            quociente = dividendo/divisor;
            resto=dividendo%divisor;

            return quociente;


        }



    }