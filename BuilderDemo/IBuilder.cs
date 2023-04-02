using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public interface IBuilder
    {
        public void BuildFloors();
        public void BuildWalls();
        public void BuildRoof();
        public void BuildSwimmingPool();

    }
           



}
