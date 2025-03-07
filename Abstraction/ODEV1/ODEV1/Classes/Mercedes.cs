using ODEV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classes
{
    public class Mercedes : IHareket
    {
        

        public void Swim()
        {
            Console.Write("Mercedes: denizde yüzer.");
        }

        public void Fly()
        {
            Console.WriteLine(",havada uçar.");
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
