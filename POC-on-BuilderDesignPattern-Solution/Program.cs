using POC_on_BuilderDesignPattern_Solution.Models;

namespace POC_on_BuilderDesignPattern_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============POC on Builder Design Pattern (Solution)==============");
            Console.WriteLine();

            Console.WriteLine("The Builder Design Pattern is Part of Creational Design Pattern");
            Console.WriteLine();

            // The Builder Design Pattern is a creational design pattern that allows for the step-by-step construction of complex objects.
            // It separates the construction of an object from its representation, enabling the creation of objects with different configurations using a consistent process.
            // The Builder pattern is particularly useful when an object has multiple optional attributes or parameters.

            Console.WriteLine("We have implemented the Builder Design Pattern to avoid issues with constructors having too many parameters");
            Console.WriteLine("In this solution, a 'BikeDirector' is used to construct the bike objects,\nand the builders (SportBikeBuilder and CruiserBikeBuilder) handle the actual bike construction");
            Console.WriteLine();

            // Building a Sports Bike
            SportBikeBuilder sportsBuilder = new SportBikeBuilder();
            BikeDirector director = new BikeDirector();

            director.Construct(sportsBuilder);
            Bike sportsBike = sportsBuilder.GetBike();
            Console.WriteLine("Details of the Sports Bike:");
            Console.WriteLine(sportsBike.GetBikeDetails());
            Console.WriteLine();

            // Building a Cruiser Bike
            CruiserBikeBuilder cruiserBuilder = new CruiserBikeBuilder();
            director.Construct(cruiserBuilder);
            Bike cruiserBike = cruiserBuilder.GetBike();
            Console.WriteLine("Details of the Cruiser Bike:");
            Console.WriteLine(cruiserBike.GetBikeDetails());
            Console.WriteLine();

            Console.WriteLine("============== Solution ===============\n\n" +
                "The Builder Design Pattern solves the problem of having too many constructor parameters\n" +
                "by allowing step-by-step object construction and handling optional attributes gracefully.\n\n" +
                "It follows the 'Open for extension, Closed for modification' principle by enabling\n" +
                "the addition of new builders without modifying the core object or its director.\n");
        }
    }
}
