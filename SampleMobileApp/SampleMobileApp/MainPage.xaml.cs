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
            btnEdit.Clicked += BtnEdit_Clicked;
            btnSave.Clicked += BtnSave_Clicked;
		}

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            string nama = entryNama.Text;
            DisplayAlert("Keterangan", $"Nama anda {nama}", "OK");
        }

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih tombol Edit", "OK");
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih tombol Add", "OK");
        }
    }
}
