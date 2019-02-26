using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Übung04_Logging
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            try
            {
                var result = DivideNumbers();
                Console.WriteLine($"Ergebnis: {result}");
                _log.Debug($"Ergebnis: {result}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Eingabe ist keine Zahl.");
                _log.Error("Eingabe ist keine Zahl.", ex);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Nicht defniert. Man kann nicht durch 0 teilen.");
                _log.Error("Nicht defniert. Man kann nicht durch 0 teilen.", ex);
            }
            catch (Exception ex )
            {
                Console.WriteLine("Woops das hätte nicht passieren sollen." + ex.Message);
                _log.Error("Woops das hätte nicht passieren sollen.", ex);
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        private static int DivideNumbers()
        {

            _log.Debug("Zähler wird eingegeben...");
            Console.Write("Zähler: ");
            var a = int.Parse(Console.ReadLine());
            _log.Debug($"Zähler ist {a}");

            _log.Debug("Nenner wird eingegeben...");
            Console.Write("Nenner: ");
            var b = int.Parse(Console.ReadLine());
            _log.Debug($"Nenner ist {b}");

            return a / b;
        }

    }
}
