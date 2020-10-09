using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOkay.Model
{
    public class Food : ICore<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
