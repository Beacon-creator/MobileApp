using MobileApp.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        [Obsolete]
        public ForgotPasswordPage()
        {
            InitializeComponent();
            BindingContext = new ForgotPasswordViewModel(this);
        }

        private void TapGestureRecognizer_JoinUs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignupPage());
        }

        private void RecoverAccountButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}