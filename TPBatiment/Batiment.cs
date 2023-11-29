using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBatiment
{
    public class Batiment
    {
        private string _Adresse;
        private string _Couleur;

        public Batiment()
        {
        } 

        public Batiment(string adresse, string couleur)
        {
            Adresse = adresse;
            Couleur = couleur;
        }

        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public string Couleur { get => _Couleur; set => _Couleur = value; }

        public override string? ToString()
        {
            return $"Adresse : {Adresse}, Couleur : {Couleur}";
        }
    }
}
