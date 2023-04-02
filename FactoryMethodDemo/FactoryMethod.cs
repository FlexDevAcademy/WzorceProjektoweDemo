namespace FactoryMethodDemo
{
    abstract class Transport
    {
        public abstract IPackage FactoryMethod();

        public string LogisticOperation()
        {
            Console.WriteLine("Creating instance of factoryMethod");
            var package = FactoryMethod();
            Console.WriteLine("Delivering package started");
            var result = package.DeliverPackage();

            return "Package delivered" + result;
        }
    }

    class Package1 : IPackage
    {
        public string DeliverPackage()
        {
            return "Delivering package1";
        }
    }
    
    class Package2 : IPackage
    {
        public string DeliverPackage()
        {
            return "Delivering package2";
        }
    }

    class DHL : Transport
    {
        public override IPackage FactoryMethod()
        {
            return new Package1();
        }
    } 
    
    class InPost : Transport
    {
        public override IPackage FactoryMethod()
        {
            return new Package2();
        }
    }

    public interface IPackage
    {
        string DeliverPackage();
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("Using DHL");
            UseCompany(new DHL());
            Console.WriteLine("Using InPost");
            UseCompany(new InPost());

        }

        public void UseCompany(Transport transport)
        {
            Console.WriteLine("Starting to use tramsport" + transport.GetType().ToString());
            Console.WriteLine(transport.LogisticOperation());
        }
    }
}
