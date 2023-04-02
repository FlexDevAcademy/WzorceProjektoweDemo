// See https://aka.ms/new-console-template for more information
using FasadaDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, my wedding!");

        int guests = 150;
        int bandMembers = 6;


        BrideFasade brideFasade = new BrideFasade();
        Console.WriteLine(brideFasade.MakeWedding(guests, bandMembers));

        Console.ReadLine();
    }
}