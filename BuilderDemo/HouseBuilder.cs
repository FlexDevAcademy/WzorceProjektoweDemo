using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class HouseBuilder : IBuilder
    {
        House house = new House();

        public HouseBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.house = new House();
        }
        public void BuildFloors()
        {
            this.house.Add("Add floors");
        }

        public void BuildRoof()
        {
            this.house.Add("Add roof");
        }

        public void BuildSwimmingPool()
        {
            this.house.Add("Add swimming pool");
        }

        public void BuildWalls()
        {
            this.house.Add("Add walls");
        }

        public House GetHouse()
        {
            House result = this.house;
            this.Reset();
            return result;
        }
    }
}
