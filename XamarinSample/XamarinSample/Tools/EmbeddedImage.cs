using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSample.Tools
{
    public class EmbeddedImage : IMarkupExtension
    {
        public string Ressource { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(Ressource);
        }
    }
}
