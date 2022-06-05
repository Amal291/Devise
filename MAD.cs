using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    
        class MAD : CDevise
        {
            private static double tauxEuro =10.59; // 1dh = 10.59euro
            private static double tauxDollar = 9.88;


            public MAD(double v) : base(v, "DHS")
            {

            }
            public override CDevise Convertto(string symbole)
            {
            CDevise dev;
            if (valeur != 0)
            {


                if (symbole == "€")
                {
                    return (dev = new Euro(this.valeur * tauxEuro));
                }
                else if (symbole == "$")
                {
                    return (dev = new Dollar(this.valeur * tauxDollar));
                }
                else
                {
                    return (dev = this);
                }

            }

            else
            {
                Console.WriteLine("Saisissez une valeur ");
            }
            }

            public static bool operator >=(MAD m, double v) 
            {

            return m.valeur >= v;
             }
             public static bool operator <=(MAD m, double v)
                {

                return m.valeur <= v;
             //or return  !(m > v)
                 }

            public static MAD operator *(MAD m, MAD v)
            {
            MAD res = new MAD(m.valeur * v.valeur);
            return res;
             }



        }


}
     
    

