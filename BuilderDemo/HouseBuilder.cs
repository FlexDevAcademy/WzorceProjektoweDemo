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

        void IBuilder.BuildFloors()
        {
            this.house.Add("Add floors");
        }

        void IBuilder.BuildRoof()
        {
            this.house.Add("Add roof");
        }

        void IBuilder.BuildSwimmingPool()
        {
            this.house.Add("Add swimming pool");
        }

        void IBuilder.BuildWalls()
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
