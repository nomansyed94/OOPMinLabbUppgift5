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


        public int BeraknaAntalKursDagar(DayOfWeek weekend, DateTime startDate, DateTime endDate, int antalVardagar)
        {

            StartDatum = startDate;
            SlutDatum = endDate;
            antalVardagar = 0;
            var totalDays = startDate - endDate;
            for (int i = 0; i < Convert.ToInt32(totalDays); i++)
            {
                antalVardagar++;
                if (weekend == DayOfWeek.Saturday || weekend == DayOfWeek.Sunday)
                {
                    antalVardagar -= 1;
                }
            }

            return antalVardagar;
        }
        //nedan taget från stackoverflow.

            //while (antalVardagar > 0)
            //{
            //    date = date.AddDays(1);

            //    if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            //    {
            //        antalVardagar -= 1;
            //    }
            //}

            //return antalVardagar;
        

        public int PoangPerKursdag(int antalKursdagar)
        { 
            return Poang / antalKursdagar;
        }

    }
}
