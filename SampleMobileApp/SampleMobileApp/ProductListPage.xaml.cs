using SampleMobileApp.Models;
using SampleMobileApp.ViewModel;
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
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
            this.BindingContext = new ProductViewModel();
            lstProduct.ItemTapped += LstProduct_ItemTapped;
        }

        private void LstProduct_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var detailPage = new ProductDetailPage();
            var data = (Product)e.Item;
            detailPage.BindingContext = data;
            Navigation.PushAsync(detailPage);
            //DisplayAlert("Keterangan", $"Anda memilih produk {data.NamaProduct}", "OK");
        }
    }
}