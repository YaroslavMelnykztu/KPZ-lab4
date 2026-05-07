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
            
            var l1 = new Level1Support();
            var l2 = new Level2Support();
            var l3 = new Level3Support();
            var l4 = new Level4Support();

            l1.SetNext(l2);
            l2.SetNext(l3);
            l3.SetNext(l4);

            bool isHandled = false;

            while (!isHandled)
            {
                Console.WriteLine("\n--- Вітаємо у системі підтримки ---");
                Console.WriteLine("1 - Тарифи");
                Console.WriteLine("2 - Налаштування інтернету");
                Console.WriteLine("3 - Поломка на лінії");
                Console.WriteLine("4 - Зв'язок з оператором");
                Console.WriteLine("0 - Вихід");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine();

                if (input == "0") break;

                if (int.TryParse(input, out int choice))
                {
 
                    isHandled = l1.Handle(choice);

                    if (!isHandled)
                    {
                        Console.WriteLine("На жаль, такий рівень підтримки не знайдено. Спробуйте ще раз.");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка введення. Введіть число.");
                }
            }

            Console.WriteLine("Дякуємо, що скористалися нашою підтримкою!");
            Console.ReadLine();
        }
    }
}
