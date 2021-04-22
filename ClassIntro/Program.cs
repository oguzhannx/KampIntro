using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {



            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "1. Kurs";
            kurs1.KursEgitmeni = "1. Hoca";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "2. Kurs";
            kurs2.KursEgitmeni = "2. Hoca";
            kurs2.IzlenmeOranı = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "3. Kurs";
            kurs3.KursEgitmeni = "3. Hoca";
            kurs3.IzlenmeOranı = 30;

            Kurs[] kurslar = new Kurs[] 
            {
                kurs1,
                kurs2,
                kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +
                    "   " + kurs.KursEgitmeni);
            }




            Console.ReadLine();

        }
    }

    class Kurs
    {
        public String KursAdi { get; set; }
        public String KursEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }


}
