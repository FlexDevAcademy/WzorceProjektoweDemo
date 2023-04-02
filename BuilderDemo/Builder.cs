﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public interface IBuilder
    {
        public void BuildFloors();
        public void BuildWalls();
        public void BuildRoof();
        public void BuildSwimmingPool();

    }
    public class Director
    {
        private IBuilder _builder;
        public IBuilder Builder
        { set 
            { _builder = value;}
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
    public class House
    {
        public List<string> parts = new List<string>();
        public void Add(string part)
        {
            this.parts.Add(part);   
        }
        
    }

    public class HouseBuilder : IBuilder
    {
        House house = new House();
        public HouseBuilder()
        {
            this.Reset();
        }

        public void  Reset()
        {
            this.house = new House();
        }
        public void BuildFloors()
        {
            this.house.Add("Add floors");
        }

        public void BuildRoof()
        {
            this.house.Add("Add roof"); ;
        }

        public void BuildSwimmingPool()
        {
            this.house.Add("Add swimming poll"); ;
        }

        public void BuildWalls()
        {
            this.house.Add("Add walls"); ;
        }
        public House GetHouse()
        {
            House result = this.house;

            this.Reset();
                return result;

        }
        
    }
}
