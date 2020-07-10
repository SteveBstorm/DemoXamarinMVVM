using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSample.Services;

namespace XamarinSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<PersonneService>();

            MainPage = new NavigationPage(new MyTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
