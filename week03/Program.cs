/**
    * OOP Hafta 3 Ödevi
    * @author Ertan Yağmur
    * see {@link https://github.com/exproot}
    * 10/14/2022
*/
namespace HelloWorld
{

    class Product{
        public uint Price { get; set; }
        public uint ProductId { get; set; }
        public string ProductName { get; set; }

        public Product(uint p, uint id, string n){
            Price = p;
            ProductId = id;
            ProductName = n;
        }
       
    }

    class CartItem{
        public uint CartId { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; }

        public CartItem(uint id, Product p, uint q){
            CartId = id;
            this.Product = p;
            Quantity = q;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product(10,0,"Milk");
            Product bread = new Product(5,1,"Bread");
            Product soda = new Product(3,2,"Soda");

            CartItem milks =new CartItem(0, milk, 1);
            CartItem breads =new CartItem(1, bread, 2);
            CartItem sodas = new CartItem(2,soda, 3);

            ShoppingCart scart = new ShoppingCart();

            scart.Add(milks);
            scart.Add(breads);
            scart.Add(sodas);

            //scart.Remove(1);

            scart.GetList();
            System.Console.WriteLine("Total Balance : " + scart.GetBalance() + "TL"); 



        }
    }
}