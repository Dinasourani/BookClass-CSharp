using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Book
    {
        // Fields
        private string Title;
        private string Author;
        private double Price;

        // Default constructor
        public Book()
        {
            Title = "Untitled";
            Author = "unknown";
            Price = 0.0;
        }

        // Parameterized constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine("The title of the book: " + Title);
            Console.WriteLine("the author: " + Author);
            Console.WriteLine("price: " + Price);
            Console.WriteLine("----------------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

    // ۲. دریافت اطلاعات از کاربر برای شیء دوم
    Console.WriteLine("لطفاً عنوان کتاب را وارد کنید:");
    string userTitle = Console.ReadLine();

    Console.WriteLine("لطفاً نام نویسنده را وارد کنید:");
    string userAuthor = Console.ReadLine();

    Console.WriteLine("لطفاً قیمت کتاب را وارد کنید:");
    double userPrice = Convert.ToDouble(Console.ReadLine());

    // ساخت شیء دوم با مقادیری که از کاربر گرفتیم
    Book book2 = new Book(userTitle, userAuthor, userPrice);

    // ۳. نمایش اطلاعات
    Console.WriteLine("\n--- اطلاعات کتاب اول (پیش‌فرض) ---");
    book1.DisplayInfo();

    Console.WriteLine("\n--- اطلاعات کتاب دوم (ورودی کاربر) ---");
    book2.DisplayInfo();

    Console.ReadKey();

            
        }
    }
}
