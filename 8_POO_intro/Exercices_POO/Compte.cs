using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_POO
{
    internal class Compte
    {
        private string _nomClient;
        // private string _prenomClient;
        //public string PrenomClient
        //{
        //    get { return _nomClient; }
        //    set { _nomClient = value; }
        //}
        public string PrenomClient { get; set; }
        public int NumCompte { get; set; }
        public double Solde { get; set; }


        public string NomClient
        {
            get { return _nomClient;}
            set 
            {
                if (!value.Equals(string.Empty))
                {
                    _nomClient = value;
                }
            }
        }

        public Compte(int numCompte, string nomClient, string prenomClient, double solde)
        {
            NumCompte = numCompte;
            NomClient = nomClient;
            PrenomClient = prenomClient;
            Solde = solde;
        }

        public override string ToString()
        {
            return $"=============================\n" +
                $"Compte # : \t{NumCompte}\nNom : \t\t{NomClient}\nPrenom : \t{PrenomClient}\n" +
                $"Solde : \t{Solde}";
        }

    }
}
