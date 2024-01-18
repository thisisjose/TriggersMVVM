using System;
using TriggersMVVM_JSVE.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_JSVE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcategoria();
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
