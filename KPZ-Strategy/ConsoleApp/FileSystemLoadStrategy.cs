using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class FileSystemLoadStrategy : IImageLoadStrategy
    {
        public void Load(string href)
        {
            Console.WriteLine($"[Стратегія Файлової Системи]: Читання картинки з локального диска за шляхом -> {href}");
        }
    }
}
