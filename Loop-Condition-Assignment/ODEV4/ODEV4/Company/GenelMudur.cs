using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV4.Company
{
    public class GenelMudur : Calisan
    {
       
        public override double maasinizNedir()
        {
            return 80000.0;
        }
        public override string ID()
        {
            return "Ben Ahmet Yilmaz Trendyol'da Genel mudurum maasim: " + maasinizNedir();
        }
    }
}
