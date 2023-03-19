using System;

namespace Holamundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            double Sueldo;

            Nombre = "Cristian Martìn CARRIÓ";
            Edad = 32;
            Sueldo = 3500;

            Console.WriteLine("Mi nombre es: " + Nombre+" y mi edad es: " +Edad+ " y teniendo el sueldo de 3500 + 100 y ahora es " +Sueldo);

            Console.ReadKey();
        }
    }
}
