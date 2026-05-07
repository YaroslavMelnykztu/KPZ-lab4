using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument()
        {
            Content = string.Empty;
        }
        public DocumentMemento Save()
        {
            return new DocumentMemento(Content);
        }
        public void Restore(DocumentMemento memento)
        {
            Content = memento.Content;
        }

        public void PrintCurrentState()
        {
            Console.WriteLine($"[Документ]: {Content}");
        }
    }
}
