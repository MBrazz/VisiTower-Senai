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
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();

        }

        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DatabaseTower.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<Cadastrar>();

            var item = new Cadastrar()
            {
                nome = Nome.Text,
                telefone = Telefone.Text,
                senha = Senha.Text,
                usuario = Email.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Concluído", "Usuário cadastrado com sucesso", "OK", "");
                if (result)
                    await Navigation.PushAsync(new LoginPage());
            });
        }
    }
}
    

