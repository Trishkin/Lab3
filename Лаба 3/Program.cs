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
        private readonly int id = 1;
        private string namebook = "Why do I live";
        public string Namebook
        {
            get { return namebook; }
            private set { namebook = value; }
        }
        private string author { get; set; } = "Dimasik";
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private const string devel = "BSTU";
        public string Devel
        {
            get { return devel; }
            set { }
        }
        private int age = 2020;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int page = 456;
        public int Page
        {
            get { return page; }
            set { page = value; }
        }
        private int price = 105;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string typeofcover = "soft";
        public string Typeofcover
        {
            get { return typeofcover; }
            set { typeofcover = value; }
        }

        public Book(int id, string Namebook, string author, int age, int page, int price, string typeofcover)
        {
            this.id = id;
            this.Namebook = Namebook;
            this.author = author;
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
            age = 2019;
            page = 342;
            price = 20;
            typeofcover = "hard";
        }

        public Book(int joga)
        {
            id = joga;
        }

        public void Info()
        {
            Console.WriteLine($"id: {id}\nNamebook: {Namebook}\nauthor: {author}\ndevel: {devel}\nage: {age}\npage: {page}\nprice: {price}\ntypeofcover: {typeofcover}");
        }

        public void InfoClass()
        {
            Console.WriteLine($"This class have fields: id, author, devel, age, page, price, typeofcover");
        }

        public void sum(ref int a, ref int b, out int c)
        {
            c = a + b;
        }
        static Book()
        {
            Console.WriteLine($"First finish");
        }

        private Book(int yoi, int oiy)
        {
            page = yoi;
            price = oiy;
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
            Console.Write($"Enter age: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter page: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter price: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter typeofcover: ");
            string h = Console.ReadLine();
            Console.WriteLine();

            Book book1 = new Book(a, b, c, e, f, g, h);
            book1.Info();
            Console.WriteLine();
            Book book2 = new Book();
            book2.Info();
            Console.WriteLine();
            Book book3 = new Book(1);
            book3.Info();
            Console.WriteLine();
            book3.Author = "4546";

            int x = 7;
            int y = 8;
            int z;
            book3.sum(ref x,ref y,out z);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
