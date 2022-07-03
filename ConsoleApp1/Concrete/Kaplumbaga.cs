using ConsoleApp1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concrete
{
    public class Kaplumbaga : Hayvan
    {
        public override void KosmaHizi()
        {
            Console.WriteLine("Kosma Hızı= 1km/h");
        }
    }
}
