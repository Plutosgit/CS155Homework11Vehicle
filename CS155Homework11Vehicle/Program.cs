using System;

namespace CS155Homework11Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Homework11 Vehicle!");

            Person fordowner = new Person("Henry Ford");
            Truck F150 = new Truck(0,6,fordowner,2.2,4000);

            Person GMowner = new Person("Mary Barra");
            Truck Sierra = new Truck(1, 6, GMowner, 2.1, 4200);

            Person teslaowner = new Person("Elon Musk");
            Truck CyberTruck = new Truck(2, 0, teslaowner, 1.2, 2000);

            Person bmwowner = new Person("Harald Kruger");
            Truck X5 = new Truck(3, 6, bmwowner, 1.8, 3800);

            Console.WriteLine();

            Console.WriteLine("Ford F150 details...");
            Console.WriteLine(F150.ToString());
            Console.Write("Owner... ");
            Console.WriteLine(F150.getPerson().GetName());
            Console.WriteLine();

            Console.WriteLine("GM Sierra details...");
            Console.WriteLine(Sierra.ToString());
            Console.Write("Owner... ");
            Console.WriteLine(Sierra.getPerson().GetName());
            Console.WriteLine();

            Console.WriteLine("Tesla CyberTruck details...");
            Console.WriteLine(CyberTruck.ToString());
            Console.Write("Owner... ");
            Console.WriteLine(CyberTruck.getPerson().GetName());
            Console.WriteLine();

            Console.WriteLine("BMW X5 details...");
            Console.WriteLine(X5.ToString());
            Console.Write("Owner... ");
            Console.WriteLine(X5.getPerson().GetName());
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Is the Tesla Owner the same as the BMW Owner? ");      
            if (teslaowner.Equals(bmwowner))
                Console.WriteLine("Same Owners");
            else
                Console.WriteLine("Different Owners");

            Console.ReadKey();
        }
    }
}
