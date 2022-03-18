using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Product.Models
{
    class Book : Product
    {
        public string Genre;


        public Book(string genre, int no, string title, double price) : base(no, title, price)
        {
            Genre = genre;
        }
        public void BookName()
        {
            Console.WriteLine($"Name: {Title}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"Book number: {No} \n" +
                $"Book Name: {Title} \n" +
                $"Genre: {Genre} \n" +
                $"Price: {Price} AZN \n" +
                $"Count: {Count} Eded \n");
        }
    }
}