using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado, num1 = 10, num2 = 20;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. Salir");

                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = Suma(num1, num2);
                        Console.WriteLine($"Resultado de la suma: {resultado}");
                        break;
                    case 2:
                        resultado = Resta(num1, num2);
                        Console.WriteLine($"Resultado de la resta: {resultado}");
                        break;
                    case 3:
                        resultado = Multiplicacion(num1, num2);
                        Console.WriteLine($"Resultado de la multiplicación: {resultado}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                        default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 4);
        }

        static double Suma (double num1, double num2)
        {
            double resultado = num1 + num2;

            return resultado;
        }
        
        static double Resta (double num1, double num2)
        {
            double resultado = num1 - num2;

            return resultado;
        }

        static double Multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;

            return resultado;
        }
    }
}
