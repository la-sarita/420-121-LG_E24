using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule vehicule = new Vehicule("BMW", 340, 30);
            Voiture voiture1 = new Voiture("Honda", 200, 100, 4);
            Moto moto = new Moto("Yamaha", 300, 40, 12);
            Console.WriteLine(vehicule);
            Console.WriteLine(voiture1);
            Console.WriteLine(moto);
            moto.SetVitesse(150);
            voiture1.SetVitesse(380);
            Console.WriteLine(voiture1);
            Console.WriteLine(moto);
        }
    }
}
