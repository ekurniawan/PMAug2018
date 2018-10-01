using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SampleMobileApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //halaman pertama kali dijalankan
			MainPage = new NavigationPage(new MainMenuPage());
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
