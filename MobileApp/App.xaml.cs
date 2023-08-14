using MobileApp.Tables;
using MobileApp.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           // MainPage = new MainPage();

            MainPage = new NavigationPage(new SignupPage());
        }

        //Creating/showing database on appstart

        private static DataBase? database;

        public static DataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));

                }
                return database;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
