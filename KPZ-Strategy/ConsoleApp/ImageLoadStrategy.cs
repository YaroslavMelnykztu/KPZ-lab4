using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IImageLoadStrategy
    {
        void Load(string href);
    }
}
