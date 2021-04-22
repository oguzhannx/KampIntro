using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            String kurs1 = "1. Kurs";
            String kurs2 = "2. Kurs";
            String kurs3 = "3. Kurs";

            String[] kurslar = new string[]
            {
                "1. Kurs",
                "2. Kurs",
                "3. Kurs",
                "4. Kurs"
            };


            for (int i = 0 ; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }






            Console.ReadLine();
        }
    }
}
