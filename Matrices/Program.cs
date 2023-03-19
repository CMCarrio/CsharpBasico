using System;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Persona = new string[3, 2];

            Persona[0, 0] = "Martín ";
            Persona[0, 1] = "CARRIÓ";

            Persona[1, 0] = "Lucas ";
            Persona[1, 1] = "ALFONSO";

            Persona[2, 0] = "Evelina ";
            Persona[2, 1] = "HERRERO";

            for (int a = 0; a < 3; a++)
            {
                Console.WriteLine("Persona [" + a + "] = " + " " + Persona[a, 0] + " " + Persona[a, 1]);
            }

            Console.ReadKey();

        }
    }
}
