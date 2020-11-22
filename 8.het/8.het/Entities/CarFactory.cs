using _8.het.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.het.Entities
{
    class CarFactory : IToyFactory
    {
       
    
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
