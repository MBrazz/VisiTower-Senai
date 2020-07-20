using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisiTower.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();

            Navegacao();
        }

        private async void Navegacao()
        {
            await Task.Delay(3000);

            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}