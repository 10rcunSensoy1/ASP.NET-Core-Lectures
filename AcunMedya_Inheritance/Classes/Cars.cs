using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya_Inheritance.Classes
{
    public class Cars
    {
        public string Mark;
        public string Gear;
        public void Feature_print(String Mark,String Gear)
        {
            Console.WriteLine(Mark+" --> "+Gear+" Viteslidir.");
        }
    }
}
