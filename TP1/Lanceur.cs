using System;

namespace TP1 // Note: actual namespace depends on the project name.
{
    internal class Lanceur
    {
        static void Main(string[] args)
        {

            Garage garage1 = new Garage("Speedy", "Paris", 15);
            Garage garage2 = new Garage("Norauto", "Evry", 21);
            Garage garage3 = new Garage("Midas", "Versailles", 25);
            Garage garage4 = new Garage("PointS", "Rambouillet",32 );


            Voiture voiture1 = new Voiture("Renault", "Bleue", 120);
            Voiture voiture2 = new Voiture("Bugatti", "Noir", 300);
            Voiture voiture3 = new Voiture("Lada", "Blanc", 90);
            Voiture voiture4 = new Voiture("Mercedes", "Gris", 170);


            Mecanicien mecanicien1 = new Mecanicien("Roger", "Jacquot");
            Mecanicien mecanicien2 = new Mecanicien("Bernard", "kevin");
            Mecanicien mecanicien3 = new Mecanicien("Renee", "Malville");
            Mecanicien mecanicien4 = new Mecanicien("Ben", "Afleck");


            Console.WriteLine(mecanicien1.Nom);//get

            mecanicien1.Nom = "Manu";//set
            Console.WriteLine(mecanicien1.Nom);//get



            Client client1 = new Client("Robert", "De Niro");
            Client client2 = new Client("Al", "Pacino");
            Client client3 = new Client("Nathalie", "Portman");
            Client client4 = new Client("Jean", "Reno");

            client1.Voitures = voiture1;//set
            Console.WriteLine(client1.Voitures.Marque);//get

            client2.Voitures = voiture2;
            client2.VoiturePossede();

        }
    }
}
