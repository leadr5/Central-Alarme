using Mg_AlarmeApp.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mg_AlarmeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
#if DEBUG 
            HotReloader.Current.Run(this);
#endif

            MainPage = new NavigationPage(new LoginPage());
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
