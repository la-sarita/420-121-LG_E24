using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_recap
{
    internal class Program
    {

        static int x = 5;
        static void Main(string[] args)
        {
            int x = 3;
            x--;

            int y = 0;
            if (x > 5)
            {
                y = 25;
            }
            else
            {
                y++;
            }
            UneMethode();
            MaClasse.MethodeAutreClasse();
            int val = MethodeRetourneInt();
            if (EstValide())
            {
                x = 4;
            }

            double valeur;
            if (double.TryParse(Console.ReadLine(), out valeur))
            {
                valeur++;
                Console.WriteLine(valeur);
            }
            while (true)
            {

            }
        }

        static void UneMethode()
        {
            x++;
        }

        static int MethodeRetourneInt()
        {
            return 100;
        }

        static bool EstValide()
        {
            return true;
        }

    }
}
