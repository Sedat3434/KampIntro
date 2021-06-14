using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kamp";
            string kurs2 = "Programlamaya Giris Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            string[] kurslar =  new string[] { "Yazılım Geliştirme Kamp"
        ,"Programlamaya Giris Temel Kurs"
        ,"Java","Python" , "C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
