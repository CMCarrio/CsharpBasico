using System;

namespace EstructuraCiclicaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nentero;
            Nentero = 0;

            Console.WriteLine("Ingrese un número para definir la tabla de multiplicar: ");
            Nentero = int.Parse(Console.ReadLine());

            for (int a = 0; a <= 12; a++)
            {
                Console.WriteLine(Nentero + " X " + a + " = " + (Nentero * a));
            }
            Console.ReadKey();
        }
    }
}
