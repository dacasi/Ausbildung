using System;

namespace Examples
{
    public class FileNameEmptyException : Exception
    {
        public FileNameEmptyException() 
            : base("Dateiname ist leer")
        {  }
    }
}
