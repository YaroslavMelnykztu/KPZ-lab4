using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Перевірка Завдання 4 (Стратегія) ===");

            ImageElement webImage = new ImageElement("https://example.com/photo.jpg");
            Console.WriteLine($"HTML: {webImage.OuterHtml()}");
            webImage.LoadImage();

            Console.WriteLine();

            ImageElement localImage = new ImageElement("C:/Images/avatar.png");
            Console.WriteLine($"HTML: {localImage.OuterHtml()}");
            localImage.LoadImage();

            Console.WriteLine("\nНатисніть Enter для виходу...");
            Console.ReadLine();
        }
    }
}
