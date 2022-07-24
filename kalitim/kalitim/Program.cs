using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    internal class Program
    {

        class yolcu
        {
            public string adi { get; set; }
            public string soyadi { get; set; }
            public int yas { get; set; }
        }


        class bus:yolcu
        {
            public string marka { get; set; }
            public int kalk { get; set; }
            public int var { get; set; }
        }

        
        static void Main(string[] args)
        {
            bus b=new bus();
            b.adi = "vahap";
            b.soyadi = "tecim";
            b.yas = 50;
            b.var = 12;
            b.marka = "mercedes travego";
            b.kalk = 10;
            Console.WriteLine(b.adi);
            Console.WriteLine(b.soyadi);
            Console.WriteLine(b.yas);
            Console.WriteLine(b.marka);
            Console.WriteLine(b.kalk);
            Console.WriteLine(b.var);

            Console.Read();
        }
    }
}
