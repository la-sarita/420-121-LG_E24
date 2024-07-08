using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExmFin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string salutation = "Bonjour-tout-le-monde";
            string[] parties = salutation.Split('o');
            foreach (var item in parties)
            {
                Console.WriteLine(item);
            }

            List<int> nombres = new List<int>();
            nombres.Add(1);
            nombres.Add(2);
            nombres.AddRange(new List<int> { 4, 5, 6 });
            nombres.Insert(0, 3);
            nombres.InsertRange(2, new int[] { 8, 9 });
            nombres.Remove(5);
            nombres.RemoveAt(2);
            nombres.Clear();
            nombres.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(1, 2);
            dict.Add(2, 3);
            dict.Remove(5);
            Console.WriteLine(dict[5]);
        }
    }
}
