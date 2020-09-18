using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace OOPMinLabbUppgift5
{
    class Kurs
    {
        public string Namn { get; set; }

        public int Poang { get; set; }

        public DateTime SlutDatum { get; set; }

        public DateTime StartDatum { get; set; }

        public static DateTime BeraknaAntalKursDagar(DateTime date, int antalVardagar)
        {
            while (antalVardagar > 0)
            {
                date = date.AddDays(1);

                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    antalVardagar -= 1;
                }
            }
            return date;
        }

        int PoangPerKursdag(int poang, int antalKursdagar)
        { 
            return poang / antalKursdagar;
        }

    }
}
