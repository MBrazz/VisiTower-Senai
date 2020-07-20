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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaPrincipal());
        }

        private void ButtonCadastar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }
    }
}