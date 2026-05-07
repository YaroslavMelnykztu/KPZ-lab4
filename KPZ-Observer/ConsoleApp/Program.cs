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

            LightElement button = new LightElement("button");
            LightElement div = new LightElement("div");

            IEventListener clickLogger = new ClickLogger();
            IEventListener hoverNotifier = new HoverNotifier();

            button.AddEventListener("click", clickLogger);
            button.AddEventListener("mouseover", hoverNotifier);

            div.AddEventListener("mouseover", hoverNotifier);

            button.TriggerEvent("mouseover"); 
            button.TriggerEvent("click");     

            div.TriggerEvent("mouseover");    
            div.TriggerEvent("click");        

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadLine();
        }
    }
}
