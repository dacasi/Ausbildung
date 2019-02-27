using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung02_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int retries = 3;
            int? result = null;
            for (i = 0; i < retries; i++)
            {
                try
                {
                    result = DivideNumbers();
                    Console.WriteLine($"Ergebnis: {result}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Eingabe ist keine Zahl.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nicht defniert. Man kann nicht durch 0 teilen.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Zahl befindet sich außerhalb des Wertebereichs.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Woops das hätte nicht passieren sollen." + ex.Message);
                }
            }
            if (result == null && i == retries)
                Console.WriteLine($"{retries} falsche Eingabe - Abbruch");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        private static int DivideNumbers()
        {
            Console.Write("Zähler: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("Nenner: ");
            var b = int.Parse(Console.ReadLine());

            return a / b;
        }

    }
}
