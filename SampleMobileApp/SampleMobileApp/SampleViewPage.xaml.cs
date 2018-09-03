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
            stepperUsia.ValueChanged += StepperUsia_ValueChanged;
        }

        private void StepperUsia_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entryUsia.Text = stepperUsia.Value.ToString();
        }

        private void BtnGet_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", $"Nilai: {sliderSample.Value}", "OK");
        }
    }
}