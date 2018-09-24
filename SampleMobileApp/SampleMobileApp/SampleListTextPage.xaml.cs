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
    public partial class SampleListTextPage : ContentPage
    {
        public SampleListTextPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelBerita();

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (Berita)e.Item;
            DisplayAlert("Keterangan", 
                $"Judul: {data.Judul} dan Deskripsi: {data.Deskripsi}", "OK");
        }
    }
}