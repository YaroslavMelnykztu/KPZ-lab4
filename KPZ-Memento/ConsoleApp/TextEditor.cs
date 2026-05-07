using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class TextEditor
    {
        private TextDocument _document;
        private Stack<DocumentMemento> _history;

        public TextEditor(TextDocument document)
        {
            _document = document;
            _history = new Stack<DocumentMemento>();
        }
        public void Type(string text)
        {
            _history.Push(_document.Save());

            _document.Content += text;
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                DocumentMemento previousState = _history.Pop();
                _document.Restore(previousState);
                Console.WriteLine("-> Останню дію скасовано (Undo).");
            }
            else
            {
                Console.WriteLine("-> Немає дій для скасування.");
            }
        }
    }
}
