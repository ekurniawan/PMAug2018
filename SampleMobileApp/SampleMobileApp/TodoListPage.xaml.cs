using SampleMobileApp.Services;
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
    public partial class TodoListPage : ContentPage
    {
        private TodoItemServices _service;
        public TodoListPage()
        {
            InitializeComponent();
            _service = new TodoItemServices();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            lstTodo.ItemsSource = await _service.GetAllData();
        }

        private void menuAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TodoItemPage());
        }
    }
}