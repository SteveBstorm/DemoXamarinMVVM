using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSample.ViewModels;

namespace XamarinSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPersonneView : ContentPage
    {
        public ListPersonneView()
        {
            BindingContext = new ListPersonneViewModel();
            InitializeComponent();
        }
    }
}