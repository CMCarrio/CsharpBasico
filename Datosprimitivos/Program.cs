using System;

namespace Datosprimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;

            Nombre = "Cristian Martín CARRIÓ";
            Edad = 32;
            const double Sueldo = 3500;/*Las constantes son valores fijos que no pueden alterarse durante su ejecución*/

            dynamic Contenido;/*Una variable dynamic acepta valores de todo tipos. numericos, alfanumericos, booleanos etc.*/

            Contenido = false;

            Console.WriteLine("Mi nombre es " + Nombre + " y mi edad es de " + Edad + " años" + " y tengo el sueldo de " + Sueldo + " pesos");
            Console.WriteLine("Contenido: " + Contenido);
            Console.ReadKey();

        }
    }
}

