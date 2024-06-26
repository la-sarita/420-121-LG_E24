using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_POO
{
    internal class Programme
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte(300, "Gosling", "James", 300.00);
            Compte compte2 = new Compte(100, "Sang", "Shin", 3000.00);
            Compte compte3 = new Compte(200, "Dalton", "Henry", 5000.00);
            Compte[] comptes = {compte1, compte2, compte3};
            foreach (Compte compte in comptes)
            {
                Console.WriteLine(compte);
            }
        }
    }
}
