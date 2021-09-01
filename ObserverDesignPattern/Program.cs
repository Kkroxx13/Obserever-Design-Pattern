using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");

            //User Karan will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Karan", RedMI);

            //User Sagar will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Sagar", RedMI);

            //User Bhavesh will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Bhavesh", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();

            // Now product is available
            RedMI.SetAvailability("Available");
            Console.Read();
        }
    }
}
