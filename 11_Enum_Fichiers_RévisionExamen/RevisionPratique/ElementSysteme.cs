using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionPratique
{
    internal class ElementSysteme
    {
        public string Nom {  get; set; }
        public long Taille { get; set; } = 0;
        public bool LectureSeule { get; set; } = false;

        public ElementSysteme(string nom) 
        {
            Nom = nom;
        }

        public override string ToString()
        {
            return $"===================================\nNom : {Nom}\n" +
                $"Taille : {Taille} octets\n " +
                $"{(LectureSeule? "Est en lecture seule" : "")}\n";
        }

    }
}
