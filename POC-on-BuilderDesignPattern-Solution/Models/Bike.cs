using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_BuilderDesignPattern_Solution.Models
{
    internal class Bike
    {
  
        //In this class we have removed the constructor and implemented the methods for declaration
        public string BikeBrand { get; set; }
        public string BikeName { get; set; }
        public int LaunchYear { get; set; }
        public string Color { get; set; }

        public void SetBikeBrand(string bikeBrand)
        {
            BikeBrand = bikeBrand;
        }

        public void SetBikeName(string bikeName)
        {
            BikeName = bikeName;
        }

        public void SetLaunchYear(int launchYear)
        {
            LaunchYear = launchYear;
        }

        public void SetColor(string color)
        {
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
