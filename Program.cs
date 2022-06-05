using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevise ttt = new MAD(5);
            Console.WriteLine("la valeur en euro est :" + ttt.Convertto("€").ToString());
            Console.WriteLine("la valeur en dollar est :" + ttt.Convertto("$").ToString());
            Console.ReadKey();
        }
    }
}
