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
    public partial class NavigationPage2 : ContentPage
    {
        private string strKeterangan;

        public NavigationPage2()
        {
            InitializeComponent();
            btnGetGlobal.Clicked += BtnGetGlobal_Clicked;
        }

        private void BtnGetGlobal_Clicked(object sender, EventArgs e)
        {
            string strKet = $"Nama: {Global.Instance.Nama} Alamat: {Global.Instance.Email}";
            DisplayAlert("Keterangan", strKet, "OK");
        }

        public NavigationPage2(string nama,string email)
        {
            InitializeComponent();
            strKeterangan = $"Nama:{nama} dan Email:{email}";
            lblKeterangan.Text = strKeterangan;
        }


    }
}