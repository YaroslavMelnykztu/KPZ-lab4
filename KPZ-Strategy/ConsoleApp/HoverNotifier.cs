using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class HoverNotifier : IEventListener
    {
        public void HandleEvent(string eventType, LightElement sender)
        {
            Console.WriteLine($"[UI Сповіщення]: Користувач навів мишку на елемент <{sender.TagName}>.");
        }
    }
}
