using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    public class Kopek : Hayvan
    {
        public bool EvcilMi { get; set; }
        public string Cinsi { get; set; }

        public override void KosmaHizi()
        {
            Console.WriteLine("Koşma Hızı 15km/h");
        }
    }
}
