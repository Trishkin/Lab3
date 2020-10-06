using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    class Book
    {
        private int id = 1;
        protected string Namebook = "Why do I live";
        protected string author = "Dimasik";
        public string devel = "BSTU";
        public int age = 2020;
        public int page = 456;
        public int price = 105;
        public string typeofcover = "soft";

        public Book(int id, string Namebook, string author, string devel, int age, int page, int price, string typeofcover)
        {
            this.id = id;
            this.Namebook = Namebook;
            this.author = author;
            this.devel = devel;
            this.age = age;
            this.page = page;
            this.price = price;
            this.typeofcover = typeofcover;
        }

        public Book()
        {
            id = 4534568;
            Namebook = "How to become more skillfull in MTG";
            author = "Dmritriy Kulikov";
            devel = "BSTU";
            age = 2019;
            page = 342;
            price = 20;
            typeofcover = "hard";
        }

        public Book(int jopa)
        {
            id = jopa;
        }
        public void Info()
        {
            Console.WriteLine($"id: {id}\nNamebook: {Namebook}\nauthor: {author}\ndevel: {devel}\nage: {age}\npage: {page}\nprice: {price}\ntypeofcover: {typeofcover}");
        }

        static Book()
        {
            
        }
        private Book(int yoi, int oiy)
        {
            page = yoi;
            price = oiy;
        }
        public readonly Book()
        {
            int x = 7;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter id: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter Namebook: ");
            string b = Console.ReadLine();
            Console.Write($"Enter author: ");
            string c = Console.ReadLine();
            Console.Write($"Enter devel: ");
            string d = Console.ReadLine();
            Console.Write($"Enter age: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter page: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter price: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter typeofcover: ");
            string h = Console.ReadLine();
            Console.WriteLine();

            Book book1 = new Book(a, b, c, d, e, f, g, h);
            book1.Info();
            Console.WriteLine();
            Book book2 = new Book();
            book2.Info();
            Console.WriteLine();
            Book book3 = new Book(1);
            book3.Info();
            Console.WriteLine();
        }
    }
}
