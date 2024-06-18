using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_sol_exos_lab_tab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nombres = { 1, 2, 3, 4, 5, 3, 8, 5, 12, 3 };
            Console.WriteLine(nombres);
            // Exercice 12
            Console.WriteLine("CalculerSommeTableau : " + CalculerSommeTableau(nombres));
            // Exercice 13
            Console.WriteLine("CompterNombrePairs : " + CompterNombrePairs(nombres));
            // Exercice 14
            Console.WriteLine("CompterNombreOccurences : " + 
                CompterNombreOccurences(nombres, 3));
            // Exercice 15
            Console.Write("InverserElementsTableau : ");
            foreach (var item in nombres)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine(" est le tableau : ");
            int[] tableauInverse = InverserElementsTableau(nombres);
            foreach (var item in tableauInverse)
            {
                Console.Write(item + ", ");
            }
            // Exercice 16
            Console.WriteLine("\ntableauxEgaux 1,2,3 et 1,2,3 sont égaux ? " +
                TableauxEgaux(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }));
            Console.WriteLine("tableauxEgaux 1,2,3,4 et 1,2,3 sont égaux ? " +
                TableauxEgaux(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 }));
            Console.WriteLine("tableauxEgaux 1,2,4 et 1,2,3 sont égaux ? " +
                TableauxEgaux(new int[] { 1, 2, 4 }, new int[] { 1, 2, 3 }));
            // Exercice 17
            InsererElements();
            // Exercice 18

        }

        static int CalculerSommeTableau(int[] nombres)
        {
            int somme = 0;

            foreach (int nombre in nombres)
            {
                somme += nombre;
            }

            return somme;
        }

        static int CompterNombrePairs(int[] nombres)
        {
            int nombrePairs = 0;

            foreach (int nombre in nombres)
            {
                if (nombre % 2 == 0)
                {
                    nombrePairs++;
                }
            }

            return nombrePairs;
        }

        static int CompterNombreOccurences(int[] nombres, int nombre)
        {
            int nbreOccur = 0;

            foreach (int item in nombres)
            {
                if (item == nombre)
                {
                    nbreOccur++;
                }
            }

            return nbreOccur;
        }


        static int[] InverserElementsTableau(int[] tableu)
        {
            int[] tableauInverse = new int[tableu.Length];
            int dernierePos = tableu.Length - 1;

            for (int i = 0; i < tableu.Length; i++)
            {
                tableauInverse[i] = tableu[dernierePos - i];
            }

            return tableauInverse;
        }

        static bool TableauxEgaux(int[] tableau1, int[] tableau2)
        {
            if (tableau1.Length != tableau2.Length)
            {
                return false;
            }
            else
            {
                // bool result = true;

                for (int i = 0; i < tableau1.Length; i++)
                {
                    if(tableau2[i] != tableau1[i])
                    {
                        return false;
                    }
                    // 2ème façon  
                    //result &= tableau2[i] == tableau1[i];
                }

                return true;
                //return result;
            }
        }

        static void InsererElements()
        {
            const string msgInvit = "Veuillez entrer un nombre ou \"fin\" pour terminer le programme";
            const string msgErreur = "Entrée invalide!";
            int nombre;
            int min = int.MaxValue;
            int max = int.MinValue;
            int somme = 0;
            string entree;
            int[] tableau = new int[0];
            do
            {
                Console.WriteLine(msgInvit);
                entree = Console.ReadLine();
                if (entree.ToLower().Equals("fin"))
                {
                    break;
                }
                else
                {
                    if (int.TryParse(entree, out nombre))
                    {
                        // Créer un tableau temporaire d'une taille de plus que celle de tableau
                        int[] newTableau = new int[tableau.Length + 1];
                        // copier les éléments de tableau dans newTableau
                        for (int i = 0; i < tableau.Length; i++)
                        {
                            newTableau[i] = tableau[i];
                        }
                        // affecter nombre au dernier élément de newTableau
                        newTableau[newTableau.Length - 1] = nombre;
                        // Écraser le tableau par le nouveau tableau
                        tableau = newTableau;
                        somme += nombre;
                        if(nombre < min)
                        {
                            min = nombre; 
                        }

                        if(nombre > max)
                        {
                            max = nombre; 
                        }
                    }
                    else
                    {
                        Console.WriteLine(msgErreur);
                    }
                }
            } while (!entree.ToLower().Equals("fin"));

            // ou réutiliser la méthode existante
            //int somme = CalculerSommeTableau(tableau);

            // Calcul de la moyenne
            int moyenne = somme / tableau.Length;
            // Affichage des statistiques 
            Console.WriteLine($"La somme des nombres est : {somme}\n" +
                $"La moyenne est : {moyenne}\n" +
                $"Le plus grand nombre est : {max}\n" +
                $"Le plus petit nombre est : {min}");
            
        }
    }
}