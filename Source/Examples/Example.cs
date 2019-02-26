using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examples
{
    public class Example
    {
        public void Start()
        {
            var text = LoadFile("hallo.txt");
            Console.WriteLine(text);

            Console.ReadKey();
        }


        public string LoadFileA(string a_file)
        {
            return File.ReadAllText(a_file);
        }


        public string LoadFile(string a_file)
        {
            try
            {
                return File.ReadAllText(a_file);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Datei konnte nicht gelesen werden.\n" + ex.ToString());
            }
            return string.Empty;
        }
    }
}
