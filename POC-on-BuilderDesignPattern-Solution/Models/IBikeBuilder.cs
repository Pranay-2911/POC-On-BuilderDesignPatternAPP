using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_BuilderDesignPattern_Solution.Models
{
    internal interface IBikeBuilder
    {
        void BuildBikeBrand();
        void BuildBikeName();
        void BuildLaunchYear();
        void BuildColor();
        Bike GetBike();
    }
}
