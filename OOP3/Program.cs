using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediMangaer = new ihtiyacKrediManger();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konut = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediMangaer, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
