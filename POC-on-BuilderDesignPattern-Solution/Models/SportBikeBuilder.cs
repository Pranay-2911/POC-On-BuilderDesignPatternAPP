using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_BuilderDesignPattern_Solution.Models
{
    internal class SportBikeBuilder : IBikeBuilder
    {
        private Bike _bike = new Bike();

        public void BuildBikeBrand()
        {
            _bike.SetBikeBrand("Triumph");
        }

        public void BuildBikeName()
        {
            _bike.SetBikeName("Daytona 600");
        }

        public void BuildLaunchYear()
        {
            _bike.SetLaunchYear(2023);
        }

        public void BuildColor()
        {
            _bike.SetColor("Black");
        }

        public Bike GetBike()
        {
            return _bike;
        }
    }
}
