using System;

namespace EstructuraCiclicaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Correlativo;
            Correlativo = 0;
            Console.WriteLine("La tabla del #7");

            while (Correlativo<=12)
            {

                Console.WriteLine("7 x "+Correlativo+" = " + (7 * Correlativo));
                Correlativo++;

            }

            Console.ReadKey();

        }
    }
}
