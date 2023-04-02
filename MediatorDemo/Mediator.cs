using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
     public interface IMediator
    {
        void Notify(object sender, string ev);

    }

    class ConcreteMediator: IMediator
    {
        private Component1 _component1;
        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)

        {
            this._component1 = component1;
            this._component2 = component2;

            this._component1.SetMediator(this);
            this._component2.SetMediator(this);

        }

        public void Notify(object sender, string operation)
        {
            if (operation == "A")
            {
                Console.WriteLine("Mediator react on action A and triggers on folowing operation: ");
                this._component2.DoC();
            }
            
            if (operation == "B")
            {
                Console.WriteLine("Mediator react on action B and triggers on folowing operation: ");
                this._component2.DoD();
            }



        }
    }

    class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this._mediator= mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator= mediator;
        }
    }

    class Component1: BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component1 does A");
            this._mediator.Notify(this, "A");
        }        
        
        
        public void DoB()
        {
            Console.WriteLine("Component1 does B");
            this._mediator.Notify(this, "B");
        }
    }    
    
    class Component2: BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component1 does C");
            this._mediator.Notify(this, "C");
        }        
        
        
        public void DoD()
        {
            Console.WriteLine("Component1 does D");
            this._mediator.Notify(this, "D");
        }
    }
}
