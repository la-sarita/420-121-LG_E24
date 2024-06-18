using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoListe();
            DemoDictionnaire();

        }

        public static void DemoListe()
        {
            List<int> nombres = new List<int>();
            nombres.Add(15);
            Console.WriteLine(nombres.Count);
            nombres.Add(8);
            Console.WriteLine(nombres.Count);
            nombres.Add(-5);
            Console.WriteLine(nombres.Count);

            foreach (var nombre in nombres)
            {
                Console.Write(nombre + ", ");
            }
            Console.WriteLine();

            var caracteres = new List<char> { 'A', 'B', 'C' };

            for (int i = 0; i < caracteres.Count; i++)
            {
                Console.Write(caracteres[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < caracteres.Count; i++)
            {
                Console.Write(caracteres.ElementAt(i) + " ");
            }

            Console.WriteLine();

            string[] cities = { "Mumbai", "London", "New York" };
            List<string> popularCities = new List<string>();
            Console.WriteLine(popularCities.Count);
            // Ajouter le tableau dans la liste
            popularCities.AddRange(cities);
            Console.WriteLine(popularCities.Count);
            popularCities.Add("Montreal");
            Console.WriteLine(popularCities.Count);
            var favouriteCities = new List<string>();
            // Ajouter une liste à la nouvelle liste
            favouriteCities.AddRange(popularCities);
            Console.WriteLine(favouriteCities.Count);
            favouriteCities.Add("Algers");
            Console.WriteLine(favouriteCities.Count);

            List<int> numbers = new List<int> { 10, 50, 30, 40 };
            AfficherElement(numbers);
            numbers.Insert(2, 80);
            numbers.InsertRange(1, new int[] { 5, 9, 10 });
            AfficherElement(numbers);
            numbers.RemoveAt(3);
            AfficherElement(numbers);
            bool estRetire = numbers.Remove(100);
            Console.WriteLine(estRetire ? "" : "L'element n'existe pas");
            Console.WriteLine(estRetire);
            if (numbers.Contains(100))
            {
                numbers.Remove(100);
            }
            else
            {
                Console.WriteLine("L'element n'existe pas");
            }
            estRetire = numbers.Remove(10);
            Console.WriteLine(estRetire);
            AfficherElement(numbers);
            numbers.ForEach(x =>
            {
                x++;
                Console.Write(x + " ");
            });
            numbers.ForEach(x => Doubler(x));
            Console.WriteLine();
            //numbers.Clear();
            Console.WriteLine(numbers.Count);
            numbers.Reverse();
            AfficherElement(numbers);
            numbers.Sort();
            AfficherElement(numbers);
        }

        public static void DemoDictionnaire()
        {
            // Création d'un dictionnaire
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "Un");
            numberNames.Add(2, "Deux");
            numberNames.Add(3, "Trois");
            // Accès aux éléments d'un dictionnaire
            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine("L'element avec la clé {0} et la valeur {1}", item.Key, item.Value);
            }

            var cities = new Dictionary<string, string> {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chocago, NEw York, Washigton" },
                {"India", "Mumbai, New Delhi, Pune" }
            };
            // accès par la clé
            string ukCities = cities["UK"];
            // accés par la position
            Console.WriteLine(cities.ElementAt(0).Value);
            Console.WriteLine(ukCities);
            // Vérifier que la clé exsiste avant d'accéder à
            // la valeur contenue dans l'élément qui a cette clé
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }
            else
            {
                Console.WriteLine("Le pays n'existe pas dans ce dictionnaire");
            }

            for(int i = 0; i < cities.Count; i++)
            {
                var elem = cities.ElementAt(i);
                Console.WriteLine("Les grandes villes de {0} sont : {1}", elem.Key, elem.Value);
            }
            // Mettre à jour le dictonnaire
            cities["UK"] = "Liverpool, Bristol";
            Console.WriteLine(cities["UK"]);
            //Console.WriteLine(cities["France"]); // cette ligne lance une exception car la clé
                                                   //"France" n'existe pas encore
            cities["France"] = "Paris, Lion";
            Console.WriteLine(cities["France"]);
            // Vérifier que la clé exsiste avant d'accéder à
            // la valeur contenue dans l'élément qui a cette clé
            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
                Console.WriteLine(cities["France"]);
            } 
            else
            {
                Console.WriteLine("Le pays n'existe pas!");
            }
            // Vérifier que la clé exsiste si oui sa valeur sera stockée dans la variable valeur
            if (cities.TryGetValue("Lune", out string valeur))
            {
                Console.WriteLine(valeur);
            }
            else
            {
                Console.WriteLine("Désolé! Ce pays n'existe pas!");
            }
            bool estRetire = cities.Remove("Lune");
            string message = estRetire ? "Le pays a été retiré" : "Le pays n'a pas pu être retiré";
            Console.WriteLine(cities.ContainsValue("Paris"));
            estRetire = cities.Remove("France");
            Console.WriteLine(cities.ContainsValue("Paris"));
            Console.WriteLine(message);
            Console.WriteLine("Dans notre dictionnaire il y a " + 
                cities.Count + " ville" + (cities.Count > 1 ? "s" : ""));
            Console.WriteLine(cities.First().Value);
            Console.WriteLine(cities.Last().Key);
            var villes = cities.Values;
            foreach (var ville in villes)
            {
                Console.WriteLine(ville);
            }
            var keys = cities.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            cities.Clear();
            Console.WriteLine(cities.Count);
        }

        public static int Doubler(int x)
        {
            return x * 2;
        }

        public static void AfficherElement(List<int> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write(liste[i] + " ");
            }
            Console.WriteLine();
        }

        public static void AfficherElement(List<string> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
        }
    }
}
