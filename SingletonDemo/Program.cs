// See https://aka.ms/new-console-template for more information
using SingletonDemo;

Singleton object1 = Singleton.GetInstance;
object1.Write("Singleton from object 1");

Singleton object2 = Singleton.GetInstance;
