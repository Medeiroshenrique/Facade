using System;

namespace Facade
{
    public class Subsistema_C
    {
        public void MetodoTres() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Método do subsistema C");
            Console.ResetColor();
        }
    }
}
