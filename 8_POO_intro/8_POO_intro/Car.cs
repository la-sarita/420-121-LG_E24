using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_POO_intro
{
    internal class Car
    {
        // Attributs d'instance
        public string color = "red";
        public int maxSpeed;
        // Attribut de classe (static)
        public static int maxSpeedAll = 0;

        public Car() {
            maxSpeed = 200;
        }

        public Car(int maxSpeed)
        {
            // mise à jour de l'attribut d'instance
            this.maxSpeed = maxSpeed;
            // mise à jour de l'attribut de classe
            if(maxSpeed > maxSpeedAll)
            {
                maxSpeedAll = maxSpeed;
            }
        }

        public Car(string color) : this()
        {
            this.color = color;
        }

        public Car(string color, int maxSpeedValue) : this(color)
        {
            maxSpeed = maxSpeedValue;
        }

        public void FullThrottle() 
        {
            Console.WriteLine("La voiture va aussi vite qu'elle peut!");
        }

    }
}
