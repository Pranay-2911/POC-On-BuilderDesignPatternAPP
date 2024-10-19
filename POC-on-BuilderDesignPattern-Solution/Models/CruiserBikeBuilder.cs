using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_BuilderDesignPattern_Solution.Models
{
    internal class CruiserBikeBuilder : IBikeBuilder
    {
        private Bike _bike = new Bike();

        public void BuildBikeBrand()
        {
            _bike.SetBikeBrand("Harley-Davidson");
        }

        public void BuildBikeName()
        {
            _bike.SetBikeName("Iron 883");
        }

        public void BuildLaunchYear()
        {
            _bike.SetLaunchYear(2022);
        }

        public void BuildColor()
        {
            _bike.SetColor("Matte Black");
        }

        public Bike GetBike()
        {
            return _bike;
        }
    }
}
