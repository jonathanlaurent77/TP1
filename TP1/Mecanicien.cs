using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Mecanicien:Humain
    {
      
        //string Adresse { get; set; }

        public Mecanicien(string nom, string prenom) :base(nom,prenom) 
        {
            
            

        }

        public void PresentationClient(string nom)
        {

            Console.WriteLine("Bienvenue au Garage Mr." + nom);

        }


    }
}
