﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOkay.Model
{
    public class Item : ICore<int>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Qty { get; set; }

        [JsonIgnore]
        public string Email { get; set; }
    }
}
