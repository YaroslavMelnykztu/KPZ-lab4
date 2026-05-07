using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Level1Support : SupportHandler
    {
        public override bool Handle(int level)
        {
            if (level == 1)
            {
                Console.WriteLine("Рівень 1: Надаємо загальну інформацію.");
                return true;
            }

            return _nextHandler != null && _nextHandler.Handle(level);
        }
    }

    public class Level2Support : SupportHandler
    {
        public override bool Handle(int level)
        {
            if (level == 2)
            {
                Console.WriteLine("Рівень 2: Технічна підтримка першої лінії.");
                return true;
            }
            return _nextHandler != null && _nextHandler.Handle(level);
        }
    }

    public class Level3Support : SupportHandler
    {
        public override bool Handle(int level)
        {
            if (level == 3)
            {
                Console.WriteLine("Рівень 3: Глибока технічна діагностика.");
                return true;
            }
            return _nextHandler != null && _nextHandler.Handle(level);
        }
    }

    public class Level4Support : SupportHandler
    {
        public override bool Handle(int level)
        {
            if (level == 4)
            {
                Console.WriteLine("Рівень 4: Адміністративні питання та скарги.");
                return true;
            }
            return _nextHandler != null && _nextHandler.Handle(level);
        }
    }
}
