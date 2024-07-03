using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_exercices_divers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartitionnerListe();

            var cities = new Dictionary<string, string> {
                {"UK", "London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washigton" },
                {"India", "Mumbai, New Delhi, Pune" }
            };
            cities["USA"] = cities["USA"] + ", Boston";

            List<string> listUk = new List<string> { "London", "Manchester", "Birmingham" };
            List<string> listUsa = new List<string> { "Chicago", "New York", "Washigton" };
            List<string> listIndia = new List<string>();
            listIndia.Add("Mumbai");
            listIndia.Add("New Delhi");
            listIndia.Add("Pune");

            var citiesList = new Dictionary<string, List<string>> {
                {"UK", listUk },
                {"USA", listUsa },
                {"India", listIndia}
            };
            Console.WriteLine(citiesList["USA"].Count);
            citiesList["USA"].Add("Boston");
            Console.WriteLine(citiesList["USA"].Count);

            foreach (var city in citiesList)
            {
                Console.Write($"Les villes de {city.Key} sont : ");
                city.Value.ForEach(ville => Console.Write(ville + ", "));
                Console.WriteLine();
            }

        }

        public static void PartitionnerListe()
        {
            List<int> liste = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<List<int>> listPartition = new List<List<int>>();
            for (int i = 0; i < liste.Count; i += 3)
            {
                List<int> listeElem = new List<int> ();
                int index = i;
                while (index < liste.Count && index < i + 3) 
                {
                    listeElem.Add (liste[index]);
                    index++;
                }
                listPartition.Add(listeElem);
            }

            foreach (var sousListe in listPartition)
            {
                sousListe.ForEach(x => Console.Write(x + ", "));
                Console.WriteLine();
            }
        }
    }
}
