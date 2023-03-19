using System;

namespace MetodoEjemeploDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OpecacionMatematica;
            int Noperacion;
            Console.Write("¿Quieres realizar la tabla de Sumar o Multiplicar?: ");
            OpecacionMatematica = Console.ReadLine();
            Console.Write(" ¿Qué Número de tabla desea que se muestre?: ");
            Noperacion = int.Parse(Console.ReadLine());

            if (OpecacionMatematica == "SUMAR")
            {
                Sumar(Noperacion);
            }
            else if (OpecacionMatematica == "MULTIPLICAR")
            {
                multiplicar(Noperacion);
            }
            else
            {
                Console.WriteLine("Operación matemática no válida");
            }

            Console.ReadKey();
        }
        /*Método de la tabla de simar*/
        static void Sumar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " + " + a + " = " + " = " + (Numero + a));
            }
        }

        /*Método de la tabla de multiplicar*/
        static void multiplicar(int Numero)
        {
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Numero + " + " + a + " = " + " = " + (Numero * a));
            }
        }
    }
}
