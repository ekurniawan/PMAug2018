using SampleMobileApp.Models;
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
    public partial class TodoItemPage : ContentPage
    {
        private TodoItemServices _service;
        public TodoItemPage()
        {
            InitializeComponent();
            _service = new TodoItemServices();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var newTodo = new TodoItem
            {
                ID = Guid.NewGuid().ToString(),
                Name = nameEntry.Text,
                Notes = notesEntry.Text,
                Done = doneSwitch.IsToggled
            };
            try
            {
                await _service.Insert(newTodo);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}