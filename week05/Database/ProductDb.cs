using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Database
{
    public static class ProductDb
    {
        public static List<Product> Liste;

        static ProductDb()
        {
            Liste = new List<Product>();

        }

        public static void Add(Product a) {
            Liste.Add(a);
        }

        public static Product GetProduct(int id) {
            
            foreach(var item in Liste) {
                if(id == item.ProductId) {
                    return item; 
                }
            }
            return null;
            
        }

        public static void PrintList() {
            Console.WriteLine("There are " + Liste.Count.ToString() + " types of products in database which are listed below : ");
            Console.WriteLine("-----------------------");
            foreach (var item in Liste) {
                Console.WriteLine(item.ProductName + " ******* ID : " + item.ProductId.ToString());
            }
            Console.WriteLine("-----------------------");
        }

        
    }
}
