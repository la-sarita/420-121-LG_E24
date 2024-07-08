using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionPratique
{
    internal class Dossier : ElementSysteme
    {
        public List<Fichier> Fichiers {  get; set; } = new List<Fichier>();

        public Dossier(string nom) : base(nom)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"Le dossier contient : {Fichiers.Count} fichiers.";
        }
    }
}
