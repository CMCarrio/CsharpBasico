using System;

namespace MetodoEjemploUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IngreseDatos();
            Console.ReadKey();
        }

        /*Método ejemplo 1*/
        static void IngreseDatos()
        {
            string Nombre;
            Console.WriteLine("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + Nombre);
        }
    }
}
