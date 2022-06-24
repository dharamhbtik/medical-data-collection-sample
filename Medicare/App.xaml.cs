using System;
using Medicare.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Medicare
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<PatientService>();

            MainPage = new MainPage();
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
