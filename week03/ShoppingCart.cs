/**
    * OOP Hafta 3 Ödevi
    * @author Ertan Yağmur
    * see {@link https://github.com/exproot}
    * 10/14/2022
*/
namespace HelloWorld
{
    class ShoppingCart
    {
        List<CartItem> items;
        public ShoppingCart(){
            items = new List<CartItem>();
        }
        public void Add(CartItem a){
                items.Add(a);
        }
        
        public uint GetBalance(){
            uint sum = 0;
            foreach(var item in items) {
                sum += item.Quantity * item.Product.Price;
            }
            return sum;
        }

        public void GetList(){
            foreach(var item in items){
                System.Console.WriteLine(item.Quantity.ToString() + " " + item.Product.ProductName + "'s, " + item.Product.Price.ToString() + "TL for each.");
            }
        }

        public void Remove(uint id){
            for(int i = 0; i < items.Count; i++){
                if(items[i].CartId == id){
                    System.Console.WriteLine("Removing the " + items[i].Product.ProductName);
                    items.RemoveAt(i);
                }
            }

        }

    }
}