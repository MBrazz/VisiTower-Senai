using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using VisiTower.Models;
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
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DatabaseTower.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<Cadastrar>().Where(u => u.usuario.Equals(Email.Text)
            && u.senha.Equals(Senha.Text)).FirstOrDefault();

            if (myquery != null)
            {
                Navigation.PushAsync(new PaginaPrincipal());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Ops!", "Usuário ou Senha incorreta(os)", "OK", "Cancelar");
                    if (result)
                        await Navigation.PushAsync(new LoginPage());
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                });
            }

            //Navigation.PushAsync(new PaginaPrincipal());
        }

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }
    }
}
