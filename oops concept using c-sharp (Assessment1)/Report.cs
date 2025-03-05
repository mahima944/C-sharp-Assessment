using System;
using System.IO;  

namespace ConsoleApp3
{
    class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        
        public void PrintDetails()
        {
            Console.WriteLine($"Report Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

       
        public void SaveToFile()
        {
            string filePath = "Report.txt";
            File.WriteAllText(filePath, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filePath}");
        }
    }
}
