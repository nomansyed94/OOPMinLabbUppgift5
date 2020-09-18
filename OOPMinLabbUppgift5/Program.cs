using System;
using System.IO;

namespace OOPMinLabbUppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            kurs.StartDatum.Date.ToShortDateString();
        }
    }
}
