using System;

namespace CondiciónIFElseIF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nombre;
            double Sueldo;

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();
            /*El sueldo mínimo en Argentina si es que el sueldo es menor o igual a 1024*/
            /*Si tu sueldo es mayor a 1024 y menor igual a 2000, tu sueldo es rentable*/
            /*Si el sueldo ingresado es mayor a 2000, entonces tu sueldo es generoso*/

            Console.Write("Ingresa tu sueldo: ");
            Sueldo = Double.Parse(Console.ReadLine());
            /*El Sueldo mínimo en Argentina es de 1024*/

            if (Sueldo <= 1024)
            {
                Console.WriteLine(Nombre + " , El sueldo que tu tienes es igual o menor al mínimo vital en Argentina");
            }
            else if (Sueldo > 1024 && Sueldo <= 2000)

            {
                Console.WriteLine(Nombre + " , Tu Sueldo es rentable");
            }
            else if (Sueldo > 2000)
            {
                Console.WriteLine(Nombre + " , Tu Sueldo es generoso");
            }

            Console.ReadKey();
        }
    }
}
