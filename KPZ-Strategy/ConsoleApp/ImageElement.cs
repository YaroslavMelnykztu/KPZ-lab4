using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ImageElement : LightElement
    {
        public string Href { get; set; }
        private IImageLoadStrategy _loadStrategy;

        public ImageElement(string href) : base("img")
        {
            Href = href;

            if (href.StartsWith("http://") || href.StartsWith("https://"))
            {
                _loadStrategy = new NetworkLoadStrategy();
            }
            else
            {
                _loadStrategy = new FileSystemLoadStrategy();
            }
        }

        public void LoadImage()
        {
            _loadStrategy.Load(Href);
        }

        public override string OuterHtml()
        {
            return $"<{TagName} src=\"{Href}\"></{TagName}>";
        }
    }
}
