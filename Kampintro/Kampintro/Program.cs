using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategoriler";
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 9;
            double dolarBugun = 9;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Dolarda Azalış");
            }

            else if  (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolarda Artış");
            }

            else
            {
                Console.WriteLine("Dolar Sabit");
            }

            if (sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Kullanıcı Girisi");

            }
            else 
            {
                Console.WriteLine("Tekrar Deneyiniz");
            }

           



        }
    }
}
