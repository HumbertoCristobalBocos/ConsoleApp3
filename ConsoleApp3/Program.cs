using System;
using System.IO;  // include the System.IO namespace

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


            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
