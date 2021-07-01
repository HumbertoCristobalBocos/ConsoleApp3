using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car("C5");
            myObj.color = "verde";
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            Console.WriteLine(myObj.fullThrottle("Humber"));
            Console.WriteLine(myObj.fullThrottle());
            Console.WriteLine(myObj.model);
            Console.WriteLine(myObj.Cosa);
            myObj.Cosa = 3;
            Console.WriteLine(myObj.Cosa);
            myObj.honk();
        }

    }
}
