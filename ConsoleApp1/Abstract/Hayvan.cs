using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    public abstract class Hayvan
    {
        public string Isim { get; set; }
        public int AyakSayisi { get; set; }
        public bool OmurgaliMi { get; set; }

        public virtual void KosmaHizi()
        {
            Console.WriteLine("Ortalama Hız=5km/h");
        }
    }
}
