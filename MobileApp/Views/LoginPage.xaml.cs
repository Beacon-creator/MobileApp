using MobileApp.Tables;
using MobileApp.ViewsModels;
using System;
using System.ComponentModel;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginPageViewModel();
        }
        private void TapGestureRecognizer_JoinUs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }

        [Obsolete]
        private void TapGestureRecognizer_ForgotPassword(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage());
        }

        private void LoginButton_Clicked(object sender, EventArgs e)

        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "UserData.db");
            var db = new SQLite.SQLiteConnection(dbpath);
            var myquery = db.Table<User>().Where(u => u.Username.Equals(EntryUsername.Text)
            && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myquery != null)

            {
                App.Current.MainPage = new NavigationPage(new DisplayUsers());
            }

            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed username and Password", "", "Cancel");

                    if (result)
                        await Navigation.PushAsync(new LoginPage());

                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                }
                 );
            }
        }

    }
}