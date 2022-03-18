using Book_Product.Models;
using System;

namespace Book_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int type_count = GetInputCount("Please write the number of books you want: ", 1, 10);

            //int[]  arr  = new int[]  { 1, 2, 3, 4 };

            Book[] Books = new Book[type_count];

            for (int i = 0; i < type_count; i++)
            {
                int no = GetInputInt($"Please enter the {i + 1} number: ", 1, 20);

                string title = GetInputStr($"Please enter the {i + 1} book name: ", 1, 15);

                string genre = GetInputStr($"Please enter the {i + 1} genre: ", 1, 15);

                double price = GetInputDouble($"Please enter the {i + 1} price: ", 5, 100);

                int count = GetInputInt($"Please enter the {i + 1} count: ", 1, 20);



                Console.WriteLine($"{title} is created");
                Console.WriteLine("....................");

                Books[i] = new Book(genre, no, title, price)
                {
                    Count = count
                };
            }
            Console.WriteLine("List of the Books: ");
            foreach (var item in Books)
            {
                item.GetInfo();
                Console.WriteLine("--------------");
            }



            int select = GetInputInt("1. Filter books for their price \n" +
                "2. Show all the books by their name \n" +
                "0. Exterminate the window");

            do
            {
                switch (select)
                {
                    case 1:
                        {
                            Array.Sort(Books, delegate (Book price1, Book price2)
                            {
                                return price1.Price.CompareTo(price2.Price);
                            });
                            foreach (var item in Books)
                            {
                                item.GetInfo();
                            }
                        }
                        break;
                    case 2:
                        {
                            foreach (var item in Books)
                            {
                                item.BookName();
                            }
                        }
                        break;

                    case 0:
                        {

                        }
                        break;


                    default:
                        break;
                }
            } while (select < 0 || select > 4);

        }

        static int GetInputCount(string name, int min, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);
            return input;
        }

        static String GetInputStr(string name, int min, int max)
        {
            string input;
            do
            {
                Console.Write(name);
                input = Console.ReadLine();

            } while (input.Length < min || input.Length > max);
            return input;
        }

        static int GetInputInt(string name, int min = int.MinValue, int max = int.MaxValue)
        {
            int input;
            do
            {
                Console.Write(name);
                input = Convert.ToInt32(Console.ReadLine());

            } while (input < min || input > max);
            return input;
        }

        static double GetInputDouble(string name, double min, double max)
        {
            double input;
            do
            {
                Console.Write(name);
                input = Convert.ToDouble(Console.ReadLine());

            } while (input < min || input > max);
            return input;
        }
    }
}
