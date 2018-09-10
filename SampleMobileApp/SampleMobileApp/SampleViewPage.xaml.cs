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
    public partial class SampleViewPage : ContentPage
    {
        public SampleViewPage()
        {
            InitializeComponent();
            btnGet.Clicked += BtnGet_Clicked;
            btnPilih.Clicked += BtnPilih_Clicked;
            stepperUsia.ValueChanged += StepperUsia_ValueChanged;

            var listJurusan = new List<string>() {
                "Sistem Informasi","Informatika","Biologi","Teologi","Akuntansi"
            };
            pickerJurusan.ItemsSource = listJurusan;
        }

        private void BtnPilih_Clicked(object sender, EventArgs e)
        {
            string data = pickerJurusan.Items[pickerJurusan.SelectedIndex];
            DisplayAlert("Keterangan", $"Anda memilih {data}", "OK");
        }

        private void StepperUsia_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entryUsia.Text = stepperUsia.Value.ToString();
        }

        private void BtnGet_Clicked(object sender, EventArgs e)
        {
            string tanggal = dpTanggal.Date.ToShortDateString();
            DisplayAlert("Keterangan", $"Nilai: {sliderSample.Value} tanggal: {tanggal}", "OK");
        }
    }
}