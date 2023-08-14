using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MobileApp.ViewsModels
{

    public class ForgotPasswordViewModel : INotifyPropertyChanged  //adding propertychange to notify xamrin forms of changes
    {
        [Obsolete]
        public ForgotPasswordViewModel(Views.ForgotPasswordPage forgotPasswordPage)
        {

            RecoverAccountCommand = new Command(async () => await RecoverAccount(),
                                                             () => !IsBusy);
        }

        bool isBusy = false;

        //event of property changed
        public event PropertyChangedEventHandler PropertyChanged;


        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;

                RecoverAccountCommand.ChangeCanExecute();

            }

        }

        public Command RecoverAccountCommand { get; }
        async Task RecoverAccount()
        {
            IsBusy = true;
            await Task.Delay(4000);

            IsBusy = false;

            await Application.Current.MainPage.DisplayAlert("Recovery message sent", "Check mail for further instructions", "ok");
        }
    }
}
