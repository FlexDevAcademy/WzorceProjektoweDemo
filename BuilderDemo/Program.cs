// See https://aka.ms/new-console-template for more information
using BuilderDemo;

Director director = new Director();
HouseBuilder housebuilder = new HouseBuilder();
director.Builder= housebuilder;

Console.WriteLine("Build basic house");
director.BuildBasicHouse();
var house = housebuilder.GetHouse();
foreach (var part in house.parts)
{
    Console.WriteLine(part);
}
director.BuildLuxuryHouse();
var houseWithPool = housebuilder.GetHouse();
foreach (var part in houseWithPool.parts)
{
    Console.WriteLine(part);
}
