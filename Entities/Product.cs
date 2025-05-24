using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product: ProductBase
    {
        public double price { get; set; }
        public int stock { get; set; }

    }
}
