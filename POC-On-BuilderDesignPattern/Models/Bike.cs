using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_On_BuilderDesignPattern.Models
{
    internal class Bike
    {
     
        public string BikeBrand { get; set; }
        public string BikeName { get; set; }
        public int LaunchYear { get; set; }
        public string Color { get; set; }


        //This constructor has too many parameters which makes it difficult to understand and use.
        //If you want to add more parameters (like bike type, engine size, etc.),
        //you would have to modify the constructor, making the class harder to maintain.
        public Bike(string bikeBrand, string bikeName, int launchYear, string color)
        {
            
            BikeBrand = bikeBrand;
            BikeName = bikeName;
            LaunchYear = launchYear;
            Color = color;
        }

        //Printing Bike Details
        public string GetBikeDetails()
        {
            return 
                $"Bike Brand : {BikeBrand}\n" +
                $"Bike Name : {BikeName} \n" +
                $"Bike Color : {Color} \n" +
                $"Bike Launch Year : {LaunchYear} \n";
        }
    }
}
