using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Voiture
    {

        public string Marque { get; set; }
        public string Couleur { get; set; }

     

        public int Vitesse { get; set; }

        

        public Voiture(string marque, string couleur, int vitesse)
        {
            Marque = marque;
            Couleur = couleur;
            Vitesse = vitesse;
        }








    }
}
