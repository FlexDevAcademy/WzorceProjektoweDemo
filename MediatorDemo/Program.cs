// See https://aka.ms/new-console-template for more information
using MediatorDemo;

//Console.WriteLine("Hello, World!");

Component1 component1= new Component1();
Component2 component2= new Component2();

new ConcreteMediator(component1, component2);
Console.WriteLine("Triggers operation A");
component1.DoA();
Console.WriteLine("Triggers opeartion B");
component2.DoD();