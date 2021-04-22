using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            TuzelMusteri musteri2 = new TuzelMusteri();
            
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

        }
    }
}
