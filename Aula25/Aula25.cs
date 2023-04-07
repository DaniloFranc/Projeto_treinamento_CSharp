using System;

    class Aula25{

        static void Main(){
            int num=50;
            dobrar02(num);
            Console.WriteLine(num);

        }

        static void dobrar01(ref int valor){ //ref é passagem por referência e altera o valor da variável na memória armazenada.
            valor*=2;
        }
        static int dobrar02(int valor){ // aqui é passagem de valor e não altera a variável no seu espaço de memória.
            valor*=2;
            return valor;
        }

    }