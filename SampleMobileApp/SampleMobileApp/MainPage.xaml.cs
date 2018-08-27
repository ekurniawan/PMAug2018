using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleMobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnAdd.Clicked += BtnAdd_Clicked;
		}

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih tombol Add", "OK");
        }
    }
}
