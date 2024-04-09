using System;

namespace Facade
{
    public class Subsistema_B
    {
        public void MetodoDois() {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Método do subsistema B");
            Console.ResetColor();
        }
    }
}
