﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ihtiyacKrediManger : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
