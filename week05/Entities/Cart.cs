using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities {
    public class Cart {
        List<CartItem> items;
        public Cart() {
            items = new List<CartItem>();
        }
        public void Add(CartItem a) {
            items.Add(a);
            Console.WriteLine(a.Quantity.ToString() + " " + a.Product.ProductName + "'s added to the cart.");
        }

        public uint GetBalance() {
            uint sum = 0;
            foreach (var item in items) {
                sum += item.Quantity * item.Product.Price;
            }
            return sum;
        }

        public void GetList() {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Cart : ");
            foreach (var item in items) {
                System.Console.WriteLine(item.Quantity.ToString() + " " + item.Product.ProductName + "'s, " + item.Product.Price.ToString() + "TL for each.");
            }
            Console.WriteLine("-----------------------");
        }

        public void Remove(uint id) {
            for (int i = 0; i < items.Count; i++) {
                if (items[i].CartId == id) {
                    System.Console.WriteLine("Removing the " + items[i].Product.ProductName + " from the cart.");
                    items.RemoveAt(i);
                }
            }

        }

        public void Find(string name) {
            List<String> names = new List<String>();
            foreach(var item in items) {
                names.Add(item.Product.ProductName);
            }
            if(names.Contains(name)) {
                Console.WriteLine(name + " found !");
            }else {
                Console.WriteLine(name + " not found !");
            }
        }

    }
}
