using System;

namespace MetodosConParametrosYretornaResutadosTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Dias;
            double PagoxDia;

            Console.Write("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("¿Cuánto te pagan por día trabajado?: ");
            PagoxDia = double.Parse(Console.ReadLine());

            Console.Write("¿Cuántos días trabajastes?: ");
            Dias = int.Parse(Console.ReadLine());

            Console.WriteLine("El dinero obtenido por tu trabajo es: " + CaulcularTotal(PagoxDia, Dias));

            Console.ReadKey();

        }
        /*Método para obtener el total de dinero ganado por trabajo*/
        static double CaulcularTotal(double P1, int P2)
        {
            double Total;
            Total = (P1 * P2);
            return (P1 * P2);
        }
    }
}