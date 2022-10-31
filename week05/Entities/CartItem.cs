using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class CartItem {
        public uint CartId { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; }

        public CartItem(uint id, Product p, uint q) {
            CartId = id;
            this.Product = p;
            Quantity = q;
        }
    }
}
