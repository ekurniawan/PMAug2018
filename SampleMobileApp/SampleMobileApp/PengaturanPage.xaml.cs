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
    public partial class PengaturanPage : ContentPage
    {
        public PengaturanPage()
        {
            InitializeComponent();
            btnSimpan.Clicked += BtnSimpan_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Application.Current.Properties.ContainsKey("Notifikasi"))
            {
                switchNotif.IsToggled = 
                    Convert.ToBoolean(Application.Current.Properties["Notifikasi"]);
            }
        }

        private void BtnSimpan_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Notifikasi"] = switchNotif.IsToggled;
        }
    }
}