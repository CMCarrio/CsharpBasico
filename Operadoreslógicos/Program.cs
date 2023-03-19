using System;

namespace Operadoreslógicos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;
            bool Resultado;

            a = 10;
            b = 2;
            c = 0;
            d = 205;
            Resultado = !(b > c);/* Dependiendo del contenido de los paréntesis, la respuesta varía
                                   por tener el síbolo de negación adelante*/

            Console.WriteLine("Cuál es el Resultado de !(a == b): " + Resultado);
            Console.ReadKey();

        }
    }
}

