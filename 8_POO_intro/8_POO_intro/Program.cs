using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_POO_intro
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Créer une instance (objet) de type Car
            Car myCar = new Car();
            // Mettre à jour la valeur de la propriété d'instance
            myCar.color = "red";
            // Mettre à jour la valeur de la propriété d'instance
            myCar.maxSpeed = -200;
            Console.WriteLine(myCar.color);
            Console.WriteLine(myCar.maxSpeed);
            // Appeler une méthode d'instance
            myCar.FullThrottle();
            Console.WriteLine(myCar);
            Car car1 = new Car("yellow");
            Car car2 = new Car("Blue", 300);
            Console.WriteLine(car1.color);
            Console.WriteLine(car1.maxSpeed);
            Console.WriteLine(car2.color);
            Console.WriteLine(car2.maxSpeed);
            // Affichage de l'attribut de classe
            Console.WriteLine(Car.maxSpeedAll);
            Person person1 = new Person();
            // Mettre à jour la valeur de la propriété d'instance
            person1.Name = "Alain";
            Console.WriteLine(person1.Name);
        }
    }

}
