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
	public partial class AddEmployee : ContentPage
	{
		public AddEmployee ()
		{
			InitializeComponent ();
		}

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var newEmployee = new Employee
            {
                EmpName = txtEmpName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesign.Text,
                Qualification=txtQualification.Text
            };
            App.DBUtils.InsertEmployee(newEmployee);
            await Navigation.PopAsync();
        }
    }
}