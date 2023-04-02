using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Director
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildBasicHouse()
        {
            this._builder.BuildFloors();
            this._builder.BuildWalls();
            this._builder.BuildRoof();

        }

        public void BuildLuxuryHouse()
        {
            this._builder.BuildFloors();
            this._builder.BuildWalls();
            this._builder.BuildRoof();
            this._builder.BuildSwimmingPool();

        }
    }
}
