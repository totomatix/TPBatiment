using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBatiment
{
    public class Maison : Batiment
    {
        private int _NombrePieces;

        public Maison() : base()
        {
        }

        public Maison(string adresse, string couleur, int nombrePieces) : base(adresse, couleur)
        {
            NombrePieces = nombrePieces;
        }

        public int NombrePieces { get => _NombrePieces; set => _NombrePieces = value; }

        public override string? ToString()
        {
            return base.ToString() + $" Nombre de pièces : {NombrePieces}";
        }
    }
}
