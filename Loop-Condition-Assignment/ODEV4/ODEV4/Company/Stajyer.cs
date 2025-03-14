using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV4.Company
{
    public class Stajyer : Calisan
    {
        public override double maasinizNedir()
        {
            return 5000.0;
        }
        public override string ID()
        {
            return "Ben Hasan Bas Trendyol'da Stajyerim maasim: " + maasinizNedir();
        }
    }
}
