using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiTower.Models;
using VisiTower.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisiTower.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        private ServiceTimes _service = new ServiceTimes();
        public Detail()
        {
            InitializeComponent();

            ListaTimes.ItemsSource = _service.GetTimes();
        }

        private async void ListaTimes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Times;
            await Navigation.PushAsync(new VisitaPage(mydetails.Nome, mydetails.Estadio, mydetails.ImagemUrl));
        }
    }
}
