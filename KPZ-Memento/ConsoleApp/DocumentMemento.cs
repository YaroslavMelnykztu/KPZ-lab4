using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class DocumentMemento
    {
        public string Content { get; private set; }
        public DocumentMemento(string content)
        {
            Content = content;
        }
    }
}
