using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Humain
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        public double CompteEnBanque { get; set; }

        public Humain(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }


    }
}


