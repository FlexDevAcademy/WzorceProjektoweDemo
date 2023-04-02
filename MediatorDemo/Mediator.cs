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
