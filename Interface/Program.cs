using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasAbstrak2723.Interface;

namespace TugasAbstrak2723
{
    class Program
    {
        static void Main(string[] args)
        {

            ISmarthphone smartphone;

            smartphone = new xiaomi();
            smartphone.Beroperasi();

            Console.WriteLine();
            smartphone = new Samsung();
            smartphone.Beroperasi();

            Console.ReadKey();

        }
    }
}
