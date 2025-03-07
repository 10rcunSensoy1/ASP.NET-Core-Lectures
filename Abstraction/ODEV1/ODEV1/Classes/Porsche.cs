using ODEV1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1.Classes
{
    public class Porsche : IHareket
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Porsche: havada uçar.");
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
