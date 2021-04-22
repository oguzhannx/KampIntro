using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Hesaplandı");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
