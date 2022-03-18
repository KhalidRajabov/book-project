using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Product.Models
{
    class Product
    {
        public int No;
        public string Title;
        public double Price;
        public int Count;

        public Product(int no, string title, double price)
        {
            No = no;
            Title = title;
            Price = price;
        }
    }
}
