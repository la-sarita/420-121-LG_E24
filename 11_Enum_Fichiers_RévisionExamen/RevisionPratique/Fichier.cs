using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionPratique
{
    internal class Fichier : ElementSysteme
    {

        public enum TypeFichiers
        {
            TXT,
            DOC,
            PDF,
            EXCEL,
            IMAGE
        }

        public string Contenu {  get; set; } = String.Empty;
        public TypeFichiers TypeFichier { get; set; }

        public Fichier(string nom) : base(nom)
        {
            
        }

        public Fichier(string nom, string contenu) : this(nom)
        {
            Contenu = contenu;
        }

        public override string ToString()
        {
            return base.ToString() + $"Le type du fichier est {TypeFichier}\n" +
                $"Le contenu de fichier est de : {Contenu.Length} caractères";
        }

        public string ConvertirEnExtension()
        {
            switch (TypeFichier)
            {
                case TypeFichiers.TXT:
                    return ".txt";
                case TypeFichiers.PDF:
                    return ".pdf";
                case TypeFichiers.EXCEL:
                    return ".xlsx";
                case TypeFichiers.IMAGE:
                    return ".png";
                case TypeFichiers.DOC:
                    return ".docx";
                default:
                    return String.Empty;
            }
        }
    }
}
