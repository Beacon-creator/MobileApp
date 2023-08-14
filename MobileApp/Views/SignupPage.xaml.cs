using MobileApp.Tables;
using MobileApp.ViewsModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.UI.Views;




namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

   
    public partial class SignupPage : ContentPage
    {

        DatabaseHelper dbHelper;
        public SignupPage()
        {
            InitializeComponent();

            dbHelper = new DatabaseHelper();

            BackgroundColor = Color.Blue;


            TandCModel dataModel = new TandCModel
            {
                IsChecked = true,
                LabelText = "Checkbox is checked"
            };

            BindingContext = dataModel;
        }

        private void Login_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
     async public void JoinusButton_Clicked(object sender, EventArgs e)
        {
            
            if (TermsAccepted.IsChecked)
            {
                if (EntryUsername.Text != null && EntryEmail != null && EntryPassword != null)
                {
                    var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserData.db");
                    var db = new SQLiteConnection(dbpath);
                    db.CreateTable<User>();

                    //   User item = new User()
                    var item = new User()
                    {
                        Username = EntryUsername.Text,
                        Password = EntryPassword.Text,
                        Email = EntryEmail.Text,

                    };
                    // inserting data to database
                    // using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                    db.Insert(item);
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result = await this.DisplayAlert("Congratulation", "User Registration Successful", "Yes", "Cancel");

                        if (result)
                            await Navigation.PushAsync(new LoginPage { });
                    });
                }

                else if (EntryUsername.Text == null || EntryEmail == null || EntryPassword == null)
                {
                    await DisplayAlert("Sorry", "Complete all Data!", "Ok");
                }

                var person = EntryUsername.Text;

                var emails = EntryEmail.Text;

                var passwords = EntryPassword.Text;


                DependencyService.Get<IFileStorage>().CreateFile(person, emails, passwords);
            }
            else
            {
              await DisplayAlert("Error", "Please agree to the terms and conditions.", "OK");
            }




          
        }
        private void Rules_Tapped(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new PopUp()
            {
              //  IsLightDismissEnabled = false

            });

         
        }
        private void TermsAccepted_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void OnToggled(object sender, ToggledEventArgs e)
        {

        }
      
    }
    

}
