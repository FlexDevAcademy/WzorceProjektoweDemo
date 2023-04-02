namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton object1 = Singleton.GetInstance;
            object1.Write("Singleton object1");
            Singleton object2 = Singleton.GetInstance;
            object2.Write("Singleton object2");
            Singleton object3 = Singleton.GetInstance;
            object3.Write("Singleton object3");
            Console.ReadLine();
        }
    }
}