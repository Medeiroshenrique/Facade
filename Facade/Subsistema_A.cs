using System;

namespace Facade
{
    public class Subsistema_A
    {
        public void MetodoUm() {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Método do subsistema A");
            Console.ResetColor();
        }
    }
}
