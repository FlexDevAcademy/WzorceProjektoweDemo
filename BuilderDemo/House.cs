using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class House
    {
        public List<string> parts = new List<string>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }

    }
}
