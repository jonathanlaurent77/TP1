using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Client : Humain
    {

        public Voiture Voitures { get; set; }
        public Client(string nom, string prenom) : base(nom, prenom)
        {
            // this.Prenom = prenom;
            //this.Nom = nom;

        }

       

       public void VoiturePossede()
        {

            Console.WriteLine("Je conduit une voiture qui monte a "+ this.Voitures.Vitesse);

        }


    }
}
