using Syncfusion.XForms.DataForm;
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

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
            {
                case "Email":
                    e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                    break;
                case "Password":
                    e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    break;
            }
        }
    }
}