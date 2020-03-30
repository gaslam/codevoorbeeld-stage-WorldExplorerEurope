using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel();
            BindingContext = loginViewModel;
            dataForm.DataObject = loginViewModel.newUser;
        }
    }
}