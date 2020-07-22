using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiTower.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisiTower.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisitaPage : ContentPage
    {
        public VisitaPage()
        {
            InitializeComponent();
        }

        private ServiceTimes _service = new ServiceTimes();
        public VisitaPage(string Nome, string Estadio, string ImagemUrl)
        {
            InitializeComponent();

            //NomeTime.Text = Nome;
            //StatusVisita.Text = Status;
            ImagemTime.Source = ImagemUrl;
            ListaDatas.ItemsSource = _service.GetTimes().Where(x => x.Nome == Nome);
        }

        private void TextCell_Tapped(object sender, EventArgs e)
        {

        }
    }
}
