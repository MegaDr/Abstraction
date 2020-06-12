using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasAbstrak2723.AbstarClass
{
    public class Samsung : Smartphone
    {
        public override void Beroperasi()
        {
            Console.WriteLine("Samsung beroperasi apabila dayanya terisi");
            Console.WriteLine("Samsung beroperasi apabila smartphonenya diaktifkan");
        }
    }
}
