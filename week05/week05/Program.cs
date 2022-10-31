using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Database;
using System.Data;

namespace week05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product milk = new Product(10, 0, "Milk");
            Product bread = new Product(5, 1, "Bread");
            Product soda = new Product(3, 2, "Soda");

            ProductDb.Add(milk);
            ProductDb.Add(bread);
            ProductDb.Add(soda);

            ProductDb.PrintList();

            CartItem cart_item1 = new CartItem(0, ProductDb.GetProduct(1), 2);
            CartItem cart_item2 = new CartItem(1, ProductDb.GetProduct(0), 1);
            CartItem cart_item3 = new CartItem(2, ProductDb.GetProduct(2), 3);

            Cart cart1 = new Cart();

            cart1.Add(cart_item1);
            cart1.Add(cart_item2);
            cart1.Add(cart_item3);

            cart1.Remove(0);
            cart1.Find("Bread");

            cart1.GetList();
            Console.WriteLine("Total balance : " + cart1.GetBalance().ToString() + " TL"); 

        }
    }
}