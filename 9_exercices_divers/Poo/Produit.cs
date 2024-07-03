using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Produit
    {
        static int nbreProd = 0;
        public int Num { get; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public bool IndicePromo { get; set; }


        public Produit(string nom, string description, double prix, bool indicePromo)
        {
            nbreProd++;
            Num = nbreProd;
            Nom = nom;
            Description = description;
            Prix = prix;
            IndicePromo = indicePromo;
        }

        public override string ToString()
        {
            return $"\n====================================\n" +
                $"Produit # : \t{Num}\nNom : \t\t{Nom}\n" +
                $"Description : \t{Description}\nPrix : \t\t{Prix}$\n"
                + (IndicePromo ? "Ce produit est en promotion" : "");
        }
    }
}
