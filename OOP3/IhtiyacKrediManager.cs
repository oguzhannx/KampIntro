using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
