using System;
using System.Collections.Generic;
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

            Console.WriteLine("=== Перевірка Завдання 5 (Мементо) ===\n");

            TextDocument doc = new TextDocument();
            TextEditor editor = new TextEditor(doc);

            Console.WriteLine("Користувач вводить текст:");
            editor.Type("Привіт, ");
            doc.PrintCurrentState();

            editor.Type("це мій перший ");
            doc.PrintCurrentState();

            editor.Type("текстовий документ.");
            doc.PrintCurrentState();

            Console.WriteLine("\nКористувач натискає Undo (Скасувати):");
            editor.Undo();
            doc.PrintCurrentState();

            Console.WriteLine("\nКористувач натискає Undo ще раз:");
            editor.Undo();
            doc.PrintCurrentState();

            Console.WriteLine("\nКористувач друкує новий текст:");
            editor.Type("новий текст!");
            doc.PrintCurrentState();

            Console.ReadLine();
        }
    }
}
