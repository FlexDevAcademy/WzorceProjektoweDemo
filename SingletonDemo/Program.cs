using SingletonDemo;

Singleton object1 = Singleton.GetInstance;
object1.Write("Singleton from obejct 1");

Singleton object2 = Singleton.GetInstance;
object2.Write("Singleton from object 2");

Console.ReadLine();