using System;
using System.IO;

namespace OOPMinLabbUppgift5
{
    class Program
    {
        public void StartaProgrammet()
        {
            var kurs1 = new Kurs
            {
                Namn = "CMS20",
                Poang = 40,
                StartDatum = new DateTime(2020, 8, 24),
                SlutDatum = new DateTime(2020, 10, 18)
            };

            var kurs2 = new Kurs
            {
                Namn = "Databasteknik",
                Poang = 20,
                StartDatum = new DateTime(2020, 10, 19),
                SlutDatum = new DateTime(2020, 11, 15)

            };
            
            var student1 = new Student
            {
                Fornamn = "Noman",
                Efternamn = "Syed",
                Email = "noman-syed@hotmail.com",
                Telefon = 0720199138,
            };
            

            var student2 = new Student
            {
                Fornamn = "kalle",
                Efternamn = "Svante",
                Email = "kalle.svante@gmail.com",
                Telefon = 0703399825,
            };
            

            var larare = new Larare
            {
                Namn = "Stefan Holmberg",
                Email = "stefan.holmberg@nackademin.se",
                Telefon = 0123456789,
            };
            
            
        }
        static void Main(string[] args)
        {

        }
    }
}
