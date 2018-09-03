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
    public partial class LuasSegitigaPage : ContentPage
    {
        public LuasSegitigaPage()
        {
            InitializeComponent();
            btnHitung.Clicked += BtnHitung_Clicked;
        }

        private void BtnHitung_Clicked(object sender, EventArgs e)
        {
            double alas = Convert.ToDouble(entryAlas.Text);
            double tinggi = Convert.ToDouble(entryTinggi.Text);
            double hasil = 0.5 * alas * tinggi;

            entryHasil.Text = hasil.ToString();
        }
    }
}