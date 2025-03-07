using ODEV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classes
{
    public class BMW : IHareket
    {
        public void Drive()
        {
            Console.Write("BMW: çok hızlı gider.");
        }

        public void Swim()
        {
            Console.Write(",denizde yüzer.");
        }

        public void Fly()
        {
            Console.WriteLine(",havada uçar.");
        }
    }
}
