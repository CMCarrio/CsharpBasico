using System;

namespace Operadoresrelaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Numero;
            dynamic Algo;

            Nombre = "Tito";
            Numero = 200;
            Algo = "Todo me chupa un huevo";

            Console.WriteLine("Hola, Me llamo " + Nombre + " y tengo " + Numero + " años, ademas " + Algo);
            Console.ReadKey();
        }
    }
}
