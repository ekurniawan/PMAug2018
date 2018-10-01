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
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
            btnSimpleList.Clicked += BtnNavigasi_Clicked;
            btnTextList.Clicked += BtnNavigasi_Clicked;
        }

        private void BtnNavigasi_Clicked(object sender, EventArgs e)
        {
            var myButton = sender as Button;
            if (myButton.Text == "Simple List Page")
            {
                Navigation.PushAsync(new SampleListPage());
            }
            else
            {
                Navigation.PushAsync(new SampleListTextPage());
            }
        }
    }
}