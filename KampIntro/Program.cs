using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            String kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200000;
            double faizOranı = 1.45;
            Boolean girisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.40;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalmış");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artmış");
            }
            else
            {
                Console.WriteLine("değişmedi" +
                    "");
            }
            if (girisYapmisMi)
            {
                Console.WriteLine("Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Giriş Yapılamadı");
            }



            Console.WriteLine(kategoriEtiketi);

            Console.ReadLine();
        }
    }
}
