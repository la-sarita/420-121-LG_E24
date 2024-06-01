using System;

namespace MethodesBoucles
{
    class Lab
    {

        const string msgSol = "Entrez la phrase que vous voulez encrypter : ";
        const string msgSaisieNbre = "de saisir un nombre entre 1 et 25 : ";
        const string msgErreur = "Vous devez afficher un nombre entier entre 1 et 25.";
        public static void Main(string[] args)
        {
            Console.Write("Entrez un nombre : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculerFactorielleFor(x));
            Console.WriteLine(CalculerFactorielleWhile(x));
            Console.WriteLine(CalculerFactorielleDoWhile(x));
            Console.WriteLine(CalculerFactorielleRecursive(x));
            Chiffrer();
            Encrypter();
            Encrypter2();
        }

        static int CalculerFactorielleFor(int nombre)
        {
            int factoriel = 1;

            for (int i = nombre; i > 0; i--)
            {
                factoriel *= i; // factoriel = factoriel * i

            }

            return factoriel;
        }

        static int CalculerFactorielleWhile(int nombre)
        {
            int factoriel = 1;
            int i = nombre;

            while (i > 0)
            {
                factoriel *= i; // factoriel = factoriel * i
                i--;
            }

            return factoriel;
        }

        static int CalculerFactorielleDoWhile(int nombre)
        {
            int factoriel = 1;
            int i = nombre;

            if (nombre > 0)
            {
                do
                {
                    factoriel *= i; // factoriel = factoriel * i
                    i--;
                } while (i > 0);
            }


            return factoriel;
        }

        static int CalculerFactorielleRecursive(int nombre)
        {
            if (nombre == 0)
            {
                return 1;
            }
            else
            {
                return nombre * CalculerFactorielleRecursive(nombre - 1);
            }
        }

        static void Encrypter()
        {
            Console.WriteLine(msgSol);
            string phrase = Console.ReadLine();
            string phraseEncryptee = phrase.Replace('a', '5')
                                            .Replace('o', 'v')
                                            .Replace('e', 'B');

            Console.WriteLine(phraseEncryptee);
        }

        static void Encrypter2()
        {
            Console.WriteLine(msgSol);
            string phrase = Console.ReadLine();
            string phraseEncryptee = string.Empty; // ""
            foreach (char lettre in phrase)
            {
                switch (lettre)
                {
                    case 'a':
                        phraseEncryptee += '5';
                        break;
                    case 'o':
                        phraseEncryptee += 'v';
                        break;
                    case 'e':
                        phraseEncryptee += 'B';
                        break;
                    default:
                        phraseEncryptee += lettre;
                        break;
                }
            }

            Console.WriteLine(phraseEncryptee);
        }

        static void Chiffrer()
        {
            Console.WriteLine(msgSol);
            string phrase = Console.ReadLine();
            Console.WriteLine(msgSaisieNbre);
            string nombre = Console.ReadLine();
            string phraseChiffree = string.Empty;

            if (int.TryParse(nombre, out int decalage))
            {
                if (decalage < 1 || decalage > 25)
                {
                    Console.WriteLine(msgErreur);
                }
                else
                {
                    foreach (char lettre in phrase)
                    {
                        if (char.IsLetter(lettre))
                        {
                            int codeLettreDecale = lettre + decalage;

                            if ((char.IsUpper(lettre) && codeLettreDecale > 'Z')
                                || (char.IsLower(lettre) && codeLettreDecale > 'z'))
                            {
                                codeLettreDecale -= 26;
                            }

                            phraseChiffree += (char)codeLettreDecale;
                        }
                        else
                        {
                            phraseChiffree += lettre;
                        }
                    }

                    Console.WriteLine(phraseChiffree);
                }
            }
            else
            {
                Console.WriteLine(msgErreur);
            }
        }
    }
}