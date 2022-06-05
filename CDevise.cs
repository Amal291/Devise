using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    
    abstract class CDevise : IDevise
    {
        protected double valeur;
        private string symbole;
        abstract public CDevise Convertto(string symbole); // abstract: because we don't if it's $ or MAD...
       
        public CDevise(double valeur, string symbole)
        {
            this.valeur = valeur;
            this.symbole = symbole;
        }
        
        public override string ToString()
        {
            string s = this.valeur + this.symbole;
            return s;
        }

    }
}

