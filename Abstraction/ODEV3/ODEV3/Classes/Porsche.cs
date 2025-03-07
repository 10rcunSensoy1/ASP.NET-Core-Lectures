using ODEV3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV3.Classes
{
    public class Porsche : Cars , ICar
    {
        public double fuel()
        {
            double fuel1 = 0.0;
            fuel1 += yakitBilgi();
            return fuel1;
        }

        public override double yakitBilgi()
        {
            return 60.0;
        }
    }
}
