using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUp : Popup
    {
        

        public PopUp()
        {
            InitializeComponent();
        }

         void Dismiss_Popup(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}