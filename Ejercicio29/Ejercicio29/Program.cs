using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha: ");
            DateTime Fecha;
            while (true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out Fecha))
                {
                    break;
                }

                Console.Write("Fecha inválida. Ingrésela nuevamente: ");
            }

            DateTime FechaMesAnterior = new DateTime(Fecha.Year, Fecha.Month, 1).AddMonths(-1);

            Console.Write($"El primer día del mes anterior de la fecha ingresada es: {FechaMesAnterior}");

            Console.ReadKey();
        }
    }
}
