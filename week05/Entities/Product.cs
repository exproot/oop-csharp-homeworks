using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Product
    {
        public uint Price { get; set; }
        public uint ProductId { get; set; }
        public string ProductName { get; set; }

        public Product(uint p, uint id, string n)
        {
            Price = p;
            ProductId = id;
            ProductName = n;
        }
    }
   
}
