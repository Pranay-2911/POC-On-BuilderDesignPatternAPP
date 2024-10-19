using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_BuilderDesignPattern_Solution.Models
{
    internal class BikeDirector
    {
        
        public void Construct(IBikeBuilder bikeBuilder)
        {
            bikeBuilder.BuildBikeBrand();
            bikeBuilder.BuildBikeName();
            bikeBuilder.BuildLaunchYear();
            bikeBuilder.BuildColor();
        }
    }
}
