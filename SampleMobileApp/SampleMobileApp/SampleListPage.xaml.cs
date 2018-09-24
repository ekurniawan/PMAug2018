using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListPage : ContentPage
    {
        private List<string> lstNama;
        public SampleListPage()
        {
            InitializeComponent();
            lstNama = new List<string>() {
                "Erick Kurniawan","Katon Wijana","Argo Lawu","Halim Budi","Budi Sutedjo"
            };
            lvData.ItemsSource = lstNama;

            lvData.ItemTapped += LvData_ItemTapped;
        }

        private void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var nama = e.Item.ToString();
            DisplayAlert("Keterangan", $"Anda memilih data {nama}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}