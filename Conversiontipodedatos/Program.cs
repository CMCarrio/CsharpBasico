using System;

namespace Conversiontipodedatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Eres casado: ?");
            Casado = Convert.ToBoolean(Console.ReadLine());

            Console.Write("¿Cuál es tu sueldo?: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();

        }
    }
}
