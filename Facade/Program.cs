using System;

namespace Facade {
    public class Program {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            //usando os métodos que usam os subsistemas
            facade.Metodo_X();
            facade.Metodo_Y();
        }
    }
}