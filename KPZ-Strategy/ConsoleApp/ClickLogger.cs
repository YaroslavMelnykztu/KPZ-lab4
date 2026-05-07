using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ClickLogger : IEventListener
    {
        public void HandleEvent(string eventType, LightElement sender)
        {
            Console.WriteLine($"[Логер подій]: Елемент <{sender.TagName}> був клікнутий!");
        }
    }
}
