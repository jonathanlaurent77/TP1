using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Garage
    {
        string Nom_garage { get; set; }
        string Ville { get; set; }
         int Numero_voiture{ get; set; }


        public Garage(string nom_garage,string ville, int numeros_voiture)
        {
            this.Nom_garage = nom_garage;
            this.Ville = ville;
            this.Numero_voiture=numeros_voiture;


        }

        public void Reparer()
        {
            Console.WriteLine("Vehicule en reparation:" + Numero_voiture);
        }





    }
}
