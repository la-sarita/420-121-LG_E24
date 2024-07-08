using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionPratique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElementSysteme elementSysteme = new ElementSysteme("Elem Syst 1");
            elementSysteme.LectureSeule = true;
            Console.WriteLine(elementSysteme);
            Fichier fichier1 = new Fichier("Fichier1");
            fichier1.Nom += fichier1.ConvertirEnExtension();
            fichier1.TypeFichier = Fichier.TypeFichiers.PDF;
            Console.WriteLine(fichier1);
            Fichier fichier2 = new Fichier("Fichier2", "LE contenu du fichier");
            fichier2.TypeFichier = Fichier.TypeFichiers.IMAGE;
            fichier2.Nom += fichier2.ConvertirEnExtension();
            Console.WriteLine(fichier2);
            Dossier dossier = new Dossier("Dossier1");
            dossier.Fichiers.Add(fichier1);
            dossier.Fichiers.Add (fichier2);
            Console.WriteLine(dossier);
        }
    }
}
