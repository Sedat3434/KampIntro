using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin Demirog";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.izlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.KursEgitmeni = "Sedat Yılan";
            kurs2.izlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.KursEgitmeni = "Sahin Cayırlı";
            kurs3.izlenmeOrani = 80;

            Console.WriteLine(kurs1.KursAdi + "=>" + kurs1.KursEgitmeni);
            Console.WriteLine(kurs2.KursAdi + "=>" + kurs2.KursEgitmeni);
            Console.WriteLine(kurs3.KursAdi + "=>" + kurs3.KursEgitmeni);
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursEgitmeni { get; set; }

        public int izlenmeOrani { get; set; }

        

    }
    
}
