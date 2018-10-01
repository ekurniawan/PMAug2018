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
            menuGrid.Clicked += MenuNavigation_Clicked;
            menuView.Clicked += MenuNavigation_Clicked;
            menuLuas.Clicked += MenuNavigation_Clicked;
            btnListProduct.Clicked += BtnNavigasi_Clicked;
        }

        private void MenuNavigation_Clicked(object sender, EventArgs e)
        {
            var menu = sender as ToolbarItem;
            if (menu.Text == "Grid Layout")
            {
                Navigation.PushAsync(new GridLayoutPage());
            }
            else if(menu.Text== "Sample View")
            {
                Navigation.PushAsync(new SampleViewPage());
            }
            else
            {
                Navigation.PushAsync(new LuasSegitigaPage());
            }
        }

        private void BtnNavigasi_Clicked(object sender, EventArgs e)
        {
            var myButton = sender as Button;
            if (myButton.Text == "Simple List Page")
            {
                Navigation.PushAsync(new SampleListPage());
            }
            else if(myButton.Text == "Text List Page")
            {
                Navigation.PushAsync(new SampleListTextPage());
            }
            else
            {
                Navigation.PushAsync(new ProductListPage());
            }
        }
    }
}