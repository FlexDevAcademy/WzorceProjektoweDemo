// See https://aka.ms/new-console-template for more information
using FasadaDemo;

int guests = 150;
int members = 6;

BrideFacade brideFacadeInstance = new BrideFacade();
Console.WriteLine(brideFacadeInstance.MakeWedding(guests, members));
Console.ReadLine();