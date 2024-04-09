using System;

namespace Facade
{
    public class Facade
    {
        private Subsistema_A A;
        private Subsistema_B B;
        private Subsistema_C C;

        //Toda vez que esta classe é instanciada ela instancia junto os subsistemas
        public Facade() {
            A = new Subsistema_A();
            B = new Subsistema_B();
            C = new Subsistema_C();
        }

        //Simplesmente podemos criar métodos que usam os subsistemas
        //relacionados ao que temos interesse e seus métodos
        public void Metodo_X() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-----Método X-----");
            A.MetodoUm();
            B.MetodoDois();
            Console.ResetColor();
        }

        public void Metodo_Y()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n-----Método Y-----");
            A.MetodoUm();
            C.MetodoTres();
            Console.ResetColor();
        }
    }
}
