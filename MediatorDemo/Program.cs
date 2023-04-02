namespace MediatorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);
            Console.WriteLine("Triggers operation A");
            component1.DoA();
            Console.WriteLine("Triggers operation D");
            component2.DoD();
            Console.ReadLine();
        }
    }
}