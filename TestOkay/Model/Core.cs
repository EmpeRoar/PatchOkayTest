using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOkay.Model
{
    public interface ICore<I>
    {
        I ID { get; set; }
    }
}
