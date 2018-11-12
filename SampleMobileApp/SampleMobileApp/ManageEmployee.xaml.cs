using SampleMobileApp.Models;
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
    public partial class ManageEmployee : ContentPage
    {
        public ManageEmployee()
        {
            InitializeComponent();
            lstEmployee.ItemSelected += LstEmployee_ItemSelected;
            
        }
     
        protected override void OnAppearing()
        {
            lstEmployee.ItemsSource = App.DBUtils.GetAllEmployees();
        }

        private void LstEmployee_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            var empDetail = (Employee)e.SelectedItem;
        }

        private async void onAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());
        }
    }
}