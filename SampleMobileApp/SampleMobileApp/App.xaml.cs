using SampleMobileApp.DAL;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SampleMobileApp
{
	public partial class App : Application
	{
        private static DataAccess dbUtils;
        public static DataAccess DBUtils
        {
            get {
                if (dbUtils == null)
                {
                    dbUtils = new DataAccess();
                }
                return dbUtils;
            }
        }

        public App ()
		{
			InitializeComponent();
            //halaman pertama kali dijalankan
            MainPage = new NavigationPage(new TodoListPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
