using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Service
    {
        static Produit[] produits;

        public static void CreerInstances()
        {
            Produit prod1 = new Produit("Crayon", "Rouge permanant", 5, false);
            Produit prod2 = new Produit("Cahier", "164 page avec relieur", 10, true);
            Produit prod3 = new Produit("Agenda", "2025 A4", 20, true);
            produits = new Produit[3] { prod1, prod2, prod3};
        }

        public static void AfficherProduitEnPromo()
        {
            foreach (var produit in produits)
            {
                if (produit.IndicePromo)
                {
                    Console.WriteLine(produit);
                }
            }
        }

        public static void ReduirePrix7()
        {
            foreach (var produit in produits)
            {
                if (produit.IndicePromo)
                {
                    produit.Prix = produit.Prix * (1 - 7.0/100);
                }
            }
        }
    }
}
