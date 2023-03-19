using System;

namespace Estructuracicliicadowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Numero;

            Numero = 0;

            do
            {

                Console.WriteLine(" El valor de la variable número es: " + Numero);
                Numero++;/*o si no de la forma tradicional Numero = Numero + 1;*/


            } while (Numero <= 10);
            Console.ReadKey();

        }
    }
}
