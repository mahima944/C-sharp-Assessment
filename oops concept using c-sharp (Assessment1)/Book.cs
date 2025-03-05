using System;

namespace ConsoleApp3
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        
        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
            ISBN = "000-0000000000";
        }

        
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "000-0000000000"; 
        }

        
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"\nBook Details:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
