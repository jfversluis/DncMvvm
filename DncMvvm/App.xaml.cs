using Xamarin.Forms;
using FreshMvvm;

namespace DncMvvm
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabbedPage = new FreshTabbedNavigationContainer();

			// Sorry about the horrible looking icon sizes...
			tabbedPage.AddTab<DncMvvmPageModel>("Home", "icon.png");
			tabbedPage.AddTab<AnotherPageModel>("Another", "anothericon.png");

			MainPage = tabbedPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
