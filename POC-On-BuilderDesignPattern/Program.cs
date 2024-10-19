using POC_On_BuilderDesignPattern.Models;

namespace POC_On_BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============POC on Builder Design Pattern (Violation) ==============");
            Console.WriteLine();

            Console.WriteLine("The Builder Design Pattern is Part of Creational Design Pattern");
            Console.WriteLine();

            //The Builder Design Pattern is a creational design pattern that allows for the step-by-step construction of complex objects.
            //it separates the construction of an object from its representation, enabling the creation of objects with different configurations using a consistent process.
            //The Builder pattern is particularly useful when an object has multiple optional attributes or parameters.


            Console.WriteLine("We have created a bike class and created a bike obj by its construtor");
            Console.WriteLine();

            Bike bike = new Bike("Triump", "Speed 400", 2023, "Black");
            Console.WriteLine(bike.GetBikeDetails());

            Console.WriteLine("============== Violation =============== \n \n" +
                "The constructor has too many parameters\n\n" +
                "If new parameters need to be added, you have to modify the constructor, \n" +
                "which violates the open for extension and closed for modification\n\n" +
                "Due to this it became Hard to maintain, especially when many optional parameters exist\n");
            
            


        }
    }
}
