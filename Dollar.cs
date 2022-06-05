using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{

    class Dollar : CDevise
    {
        private double tauxEuro = 1,07;
        private double tauxMad = 0,10;

        public Dollar(double v) : base(v, "$")
        {
        }


        public override CDevise Convertto(string symbole)
        {
            CDevise dev;
            if (valeur != 0)
            {
                if (symbole == "€")
                {
                    return dev = new Euro(this.valeur * tauxEuro);
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

            
        public static bool operator >=(Dollar m, double v) 
        { 


            return m.valeur >= v;
        }
        public static bool operator <=(Dollar m, double v)
        {

            return m.valeur <= v;
           
        }

     
        public static Dollar operator *(Dollar m, Dollar v)
        {
            Dollar res = new Dollar(m.valeur * v.valeur);
            return res;
        }

}

    


