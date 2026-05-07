using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class NetworkLoadStrategy : IImageLoadStrategy
    {
        public void Load(string href)
        {
            Console.WriteLine($"[Стратегія Мережі]: Завантаження картинки з інтернету за адресою -> {href}");
        }
    }
}
