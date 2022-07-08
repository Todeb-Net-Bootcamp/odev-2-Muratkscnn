using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yorum Satırına ihtiyaç duymucağınızı düşünüyorum :D
            Kaplumbaga hayvan1 = new Kaplumbaga()
            {
                Isim = "Tospik",
                AyakSayisi = 4,
                OmurgaliMi = true
            };
            Kopek hayvan2 = new Kopek()
            {
                Isim = "Ares",
                Cinsi = "Rottweiler",
                AyakSayisi = 4,
                EvcilMi = false,
                OmurgaliMi = true
            };

            Console.WriteLine($"İsim={hayvan1.Isim}");
            Console.WriteLine($"Kaç Ayaklı={hayvan1.AyakSayisi}");
            Console.WriteLine($"Omurgalı Mı?={hayvan1.OmurgaliMi}");
            hayvan1.KosmaHizi();
            Console.WriteLine("------------");

            Console.WriteLine($"İsim={hayvan2.Isim}");
            Console.WriteLine($"Cinsi={hayvan2.Cinsi}");
            Console.WriteLine($"Evcil={hayvan2.EvcilMi}");
            Console.WriteLine($"Kaç Ayaklı={hayvan2.AyakSayisi}");
            Console.WriteLine($"Omurgalı={hayvan2.OmurgaliMi}");
            hayvan2.KosmaHizi();


        }
    }
}
