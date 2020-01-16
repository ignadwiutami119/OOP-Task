using System;
using methodchain;

namespace methodchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            cart.addItem(1, 30000, 2)
                .addItem(2, 10000)
                .addItem(3, 5000, 4)
                .remove(2)
                .addItem(4, 400, 6).discount("50%");
            
            Console.WriteLine("jenis item : {0}", cart.totalItems());
            Console.WriteLine("jumlah item : {0}", cart.totalQuantity());
            Console.WriteLine("juamlah harga : {0}", cart.totalPrice());
            cart.showItem();
            cart.checkout("D:/");
        }
    }
}