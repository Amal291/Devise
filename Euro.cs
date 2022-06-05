using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{

    class Euro : CDevise
    {
        private static double tauxDollar = 10.00;
        private static double tauxMad = 1.09;


        public Euro(double v) : base(v, "€")
        {

        }
        public override CDevise Convertto(string symbole)
        {

            CDevise dev;
            if (valeur != 0)
            {
                if (symbole == "$")
                {
                    return dev = new Dollar(this.valeur * tauxDollar);
                }
                else if (symbole == "DHS")
                {
                    return dev = new MAD(this.valeur * tauxMad);
                }
                else
                {
                    return dev = this;
                }

            }
            else
            {
                Console.WriteLine("Saisissez une valeur ");
            }
        }
        public static bool operator >=(Euro m, double v)
        {


            return m.valeur >= v;
        }
        public static bool operator <=(Euro m, double v)
        {

            return m.valeur <= v;

        }

        public static Euro operator *(Euro m, Euro v)
        {
            Euro res = new Euro(m.valeur * v.valeur);
            return res;
        }

       


    }
    


}





