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
            try
            {
                var result = DivideNumbers();
                Console.WriteLine($"Ergebnis: {result}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Eingabe ist keine Zahl.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Nicht defniert. Man kann nicht durch 0 teilen.");
            }
            catch (Exception ex )
            {
                Console.WriteLine("Woops das hätte nicht passieren sollen." + ex.Message);
            }

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
