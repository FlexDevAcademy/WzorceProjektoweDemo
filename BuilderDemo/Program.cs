﻿namespace BuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            HouseBuilder houseBuilder = new HouseBuilder();
            director.Builder = houseBuilder;
            
            Console.WriteLine("Build basic house");
            director.BuildBasicHouse();
            var house = houseBuilder.GetHouse();
            foreach(var part in house.parts)
            {
                Console.WriteLine(part);
            }

            Console.WriteLine("Build luxury house");
            director.BuildLuxuryHouse();
            var houseWithPool = houseBuilder.GetHouse();

            foreach (var part in houseWithPool.parts)
            {
                Console.WriteLine(part);
            }

            Console.ReadLine();
        }
    }
}