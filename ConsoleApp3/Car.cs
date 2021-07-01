using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car : Vehicle
    {
        public string color = "red";
        public string model;
        public int maxSpeed = 200;
        private int cosa = 1;
        public int Cosa
        {
            get { return cosa; }
            set { cosa = value; }
        }

        public Car(string modelName)
        {
            model = modelName;
        }

        public string fullThrottle( string nombre = "Jose")   // method
        {
            string texto ="The car is going as fast as it can!" + nombre;
            fullThrottle2(cosa);
            return texto;
        }

        public static void fullThrottle2(int cosa)    // method
        {
            Console.WriteLine("The car is going as fast as it can!" + cosa);
        }
    }
}
