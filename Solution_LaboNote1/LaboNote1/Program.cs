using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboNote1
{
    internal class Program
    {
        const string menu = "Bienvenue au programme de manipulation de phrases.\n Entrez une des 4 options suivantes :\n" +
            "1. Pour afficher la phrase inversée.\n" +
            "2. Pour afficher uniquement les lettres aux positions paires.\n" +
            "3. Pour afficher le nombre de voyelles présentes dans cette phrase.\n" +
            "4. Pour afficher les voyelles en majuscule et le reste des lettres en minuscule.";
        const string msgErreur = "Entrée invalide! Veuillez entrer un nombre entre 1 et 4 inclus.";
        const string msgSolPhrase = "Veuillez entrer une phrase : ";
        const string msgResOption1 = "La phrase inversée est :\n";
        const string msgResOption2 = "La phrase avec les lettres paires est :\n";
        const string msgResOption3 = "Le nombre de voyelles dans cette phrase est :\n";
        const string msgResOption4 = "La phrase après transformation est :\n";

        static void Main(string[] args)
        {
            string phrase;
            Console.WriteLine(msgSolPhrase);
            phrase = Console.ReadLine();
            Console.WriteLine(menu);

            if(int.TryParse(Console.ReadLine(), out int option)){
                switch (option)
                {
                    case 1:
                        Console.WriteLine(msgResOption1 + InverserPhrase(phrase));            
                        break;
                    case 2:
                        Console.WriteLine(msgResOption2 + ExtraireLettresPaires(phrase));
                        break;
                    case 3:
                        Console.WriteLine(msgResOption3 + CompterVoyelles(phrase.ToLower()));
                        break;
                    case 4:
                        Console.WriteLine(msgResOption4 + TransformerVoyelles(phrase));
                        break;
                    default:
                        Console.WriteLine(msgErreur);
                        break;
                }
            } 
            else
            {
                Console.WriteLine(msgErreur);
            }

        }

        static string InverserPhrase(string phrase)
        {
            string phraseinversee = string.Empty; // ""

            foreach (char lettre in phrase)
            {
                phraseinversee = lettre + phraseinversee;
            }

            return phraseinversee;
        }

        static string ExtraireLettresPaires(string phrase)
        {
            string phraseLettresPaires = string.Empty;

            for(int i = 0; i < phrase.Length; i++)
            {
                if(i % 2 == 0)
                {
                    phraseLettresPaires += phrase.ElementAt(i);
                    //phraseLettresPaires = phraseLettresPaires + phrase.ElementAt(i);
                }
            }

            return phraseLettresPaires;
        }

        static int CompterVoyelles(string phrase)
        {
            int compteur = 0;

            foreach (char lettre in phrase)
            {
                if ("aeiou".Contains(lettre))
                {
                    compteur++;
                }
            }

            return compteur;
        }

        static string TransformerVoyelles(string phrase)
        {
            string phrasetransformee = string.Empty;

            foreach (char lettre in phrase.ToLower())
            {
                if ("aeiou".Contains(lettre))
                {
                    phrasetransformee += char.ToUpper(lettre);
                } 
                else
                {
                    phrasetransformee += char.ToLower(lettre);
                }
            }

            return phrasetransformee;
        }
    }
}
