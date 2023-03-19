using System;

namespace CondiciónIF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nombre;
            double Sueldo;

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa tu sueldo: ");
            Sueldo = Double.Parse(Console.ReadLine());
            /*El Sueldo mínimo en Argentina es de 1024*/

            if (Sueldo <= 1024)
            {
                Console.WriteLine(Nombre + ", El sueldo que tu tienes es igual o menor al mínimo vital en Argentina");
            }/*Condición con solo un resultado, si se cumple, lo lanzará..!!*/

            else /*En caso que no se cumple la condicón*/
            {
                Console.WriteLine(Nombre + ", El sueldo que tu tienes supera el minimo vital en Argentina");
            }

            Console.ReadKey();

        }
    }
}
