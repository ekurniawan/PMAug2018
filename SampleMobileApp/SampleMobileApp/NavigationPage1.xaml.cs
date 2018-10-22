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
	public partial class NavigationPage1 : ContentPage
	{
		public NavigationPage1 ()
		{
			InitializeComponent ();
            btnKirim.Clicked += BtnKirim_Clicked;
            btnSimpan.Clicked += BtnSimpan_Clicked;
            btnPage2.Clicked += BtnPage2_Clicked;
		}

        private void BtnPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage2());
        }

        private void BtnSimpan_Clicked(object sender, EventArgs e)
        {
            Global.Instance.Nama = entryNama.Text;
            Global.Instance.Email = entryEmail.Text;
            DisplayAlert("Keterangan", "Data Sudah disimpan di Global Variable", "OK");
        }

        private void BtnKirim_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage2(entryNama.Text, entryEmail.Text));
        }
    }
}