using Xamarin.Forms;

namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App3.TabbedPage();
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
