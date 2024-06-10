using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            //Console.WriteLine(age);
            AfficherInfo("Liam", out age);
            //Console.WriteLine(age);
            //AfficherInfo("Sara", 50);
            //AfficherInfo("Paul", 49);
            string chaine = "20";
            bool isParsed = int.TryParse(chaine, out int result);
            Console.WriteLine("{0} {1}", isParsed, result);
            Console.WriteLine((char)('a' + 9));
            Console.Write("Entrez un nombre : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculerFactorielle(x));
            Console.WriteLine(CalculerFactorielleFor(x));
            Console.WriteLine(CalculerFactorielleWhile(x));
            Console.WriteLine(CalculerFactorielleDoWhile(x));
            Console.WriteLine(CalulerFactorielleRecursive(x));
            //Crypter();
            //Crypter1();
            //CrypterV2();
            Console.WriteLine(Chiffrer("Bonjour tout le monde", 2));
            Console.WriteLine(Chiffrer("Zidane", 5));
        }

        static void AfficherInfo(string fName, out int age)
        {
            age = 6;
            Console.WriteLine(fName + " is " + age);
            
        }

        static int CalculerFactorielle(int nombre)
        {
            int factorielle = 1;

            if (nombre == 0)
            {
                factorielle = 1;
            } 
            else
            {
                for (int i = nombre; i > 0; i--)
                {
                    factorielle *= i;
                }
                
            }
            
            return factorielle;
        }

        static int CalculerFactorielleFor(int nombre)
        {
            int factorielle = 1;

            if (nombre > 0)
            {
                for (int i = nombre; i > 0; i--)
                {
                    factorielle *= i;
                }

            }

            return factorielle;
        }

        static int CalculerFactorielleWhile(int nombre)
        {
            int factorielle = 1;

            int i = nombre;

            while (i > 0)
            {
                factorielle *= i;
                i--;
            }

            return factorielle;
        }

        static int CalculerFactorielleDoWhile(int nombre)
        {
            int factorielle = 1;

            int i = nombre;

            do
            {
                if (i > 0)
                {
                    factorielle *= i;
                    i--;
                }
                
            } while (i > 0);

            return factorielle;
        }

        static int CalulerFactorielleRecursive(int nombre)
        {
            if(nombre == 0)
            {
                return 1;
            } else
            {
                return nombre * CalculerFactorielle(nombre - 1);
            }
        }

        static void Crypter()
        {
            Console.Write("Entrez un phrase : ");
            string phrase = Console.ReadLine();
            string phraseCryptee = phrase.Replace('a', '5')
                                         .Replace('o', 'v')
                                         .Replace('e','B');

            Console.WriteLine(phraseCryptee);
        }

        static void Crypter1()
        {
            Console.Write("Entrez un phrase : ");
            string phrase = Console.ReadLine();
            string phraseCryptee = phrase.Replace('a', '5');
            phraseCryptee = phraseCryptee.Replace('o', 'v');
            phraseCryptee = phraseCryptee.Replace('e', 'B');

            Console.WriteLine(phraseCryptee);
        }

        static void CrypterV2()
        {
            Console.Write("Entrez un phrase : ");
            string phrase = Console.ReadLine();
            string phraseCryptee = string.Empty;

            foreach (char c in phrase)
            {
                switch (c)
                {
                    case 'a':
                        phraseCryptee += '5';
                        break;
                    case 'o':
                        phraseCryptee += 'v';
                        break;
                    case 'e':
                        phraseCryptee += 'B';
                        break;
                    default:
                        phraseCryptee += c;
                        break;
                }
            }

            Console.WriteLine(phraseCryptee);
        }

        static string Chiffrer(string chaine, int decalage)
        {
            string chaineChiffree = string.Empty;

            foreach(char c in chaine)
            {
                if (char.IsLetter(c))
                {
                    int codeLettreDecalee = (c + decalage);
                    if(char.IsUpper(c) && codeLettreDecalee > 'Z' || !char.IsUpper(c) && codeLettreDecalee > 'z')
                    {
                        codeLettreDecalee -= 26;
                    }
                    chaineChiffree += (char)codeLettreDecalee;
                }
                else // if(char.IsDigit(c) || char.IsWhiteSpace(c))
                {
                    chaineChiffree += c;
                } 
                
            }
            
            return chaineChiffree;
        }
    }
}
