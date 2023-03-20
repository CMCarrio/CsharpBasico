using System;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            try
            {
                Console.Write("Ingresa tu edad, Por favor: ");
                Edad = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Erorr: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
