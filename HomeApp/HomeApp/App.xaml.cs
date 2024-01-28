using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeApp.Pages;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            // инициализация интерфейса
            InitializeComponent();
            // Инициализация главного экрана
            MainPage = new DevicesPage();
            //MainPage = new DeviceControlPage();
            //MainPage = new NewDevicePage();
            //MainPage = new CsharpPaddingPage();
            //MainPage = new PaddingPage();
            //MainPage = new GridPage();
            //MainPage = new AboutPage();
            //MainPage = new ClimatePage();
            //MainPage = new LoadingPage();
            //MainPage = new MainPage();
            //MainPage = new LoginPage();
            //MainPage = new RegisterPage();
            //MainPage = new ProfilePage();
            //MainPage = new WebPage();
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
