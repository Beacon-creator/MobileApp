using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.ViewsModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayUsers : ContentPage
    {
        public DisplayUsers()
        {
            InitializeComponent();

            BindingContext = new DisplayUsersViewModel();
        }


        protected override async void OnAppearing()
        {


            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }
    }
}