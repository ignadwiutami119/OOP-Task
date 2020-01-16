using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace methodchain
{
    public class Item
    {
        public int identify;
        public double Price;
        public int quantity;

        public Item(int id, double price, int jumlah)
        {
            identify = id;
            Price = price;
            quantity = jumlah;
        }
    }

    public class Cart
    {
        private ArrayList dat = new ArrayList();
        private double _disc;

        public Cart addItem(int identify, double price, int quant=1)
        {
            dat.Add(new Item(identify, price, quant));
            return this;
        }
        
        public Cart remove(int identify)
        {
            for(int i=0; i<dat.Count; i++)
            {
                Item item = (Item)dat[i];
                if(item.identify == identify)
                {
                    dat.RemoveAt(i);
                    break;
                }
            }
            return this;
        }

        public Cart discount(string discount)
        {
            _disc = (double)Decimal.Parse(discount.Remove(discount.Length-1))/100;
            return this;
        }

        public int totalItems()
        {
            return dat.Count;
        }

        public int totalQuantity()
        {
            int hasil = 0;

            foreach (var obj in dat)
            {
                Item item = (Item)obj;
                hasil += item.quantity;
            }
            return hasil;
        }

        public double totalPrice()
        {
            double get = 0;

            foreach (var obj in dat)
            {
                Item item = (Item)obj;
                get += item.Price;
            }
            double hasil = get - get*_disc;
            return hasil;
        }

        public void showItem()
        {
            foreach (var i in dat)
            {
                Item item = (Item)i;
                Console.WriteLine("|{0}| |{1}| |{2}|", item.identify, item.Price, item.quantity);
            }
        }

        public void checkout() {

        }
    }
}