using System;

namespace EstructuraselectivaSWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Dia;

            Console.WriteLine(" Ingrese el día en número, por favor: ");
            Dia = int.Parse(Console.ReadLine());

            switch (Dia)
            {
                case 1: 
                    Console.WriteLine("Corresponde al día de la semana, 'lunes'");
                    break;
                case 2:
                    Console.WriteLine("Corresponde al día de la semana, 'martes'");
                    break;
                case 3:
                    Console.WriteLine("Corresponde al día de la semana, 'miercoles'");
                    break;
                case 4:
                    Console.WriteLine("Corresponde al día de la semana, 'jueves'");
                    break;
                case 5:
                    Console.WriteLine("Corresponde al día de la semana, 'viernes'");
                    break;
                case 6:
                    Console.WriteLine("Corresponde al día de la semana, 'sabado'");
                    break;
                case 7:
                    Console.WriteLine("Corresponde al día de la semana, 'domingo'");
                    break;
                    
                default:
                    Console.WriteLine("El número ingresado no es válido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
