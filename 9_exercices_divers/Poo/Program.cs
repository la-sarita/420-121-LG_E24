using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service.CreerInstances();
            Service.AfficherProduitEnPromo();
            Service.ReduirePrix7();
            Service.AfficherProduitEnPromo();
        }
    }
}
