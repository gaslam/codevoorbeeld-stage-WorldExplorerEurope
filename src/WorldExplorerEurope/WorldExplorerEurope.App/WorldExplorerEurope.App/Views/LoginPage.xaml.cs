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
            btnLogin.Command = loginViewModel.LoginCommand;
            dataForm.DataObject = loginViewModel.newUser;
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
            {
                case "Email":
                    e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                    e.DataFormItem.HintLabelStyle =  new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("ROBOTOMONO-REGULAR.TTF", "ROBOTOMONO-REGULAR.TTF#ROBOTO MONO", "Assets/Fonts/ROBOTOMONO-REGULAR.TTF#ROBOTO MONO")};

                    break;
                case "Password":
                    e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("ROBOTOMONO-REGULAR.TTF", "ROBOTOMONO-REGULAR.TTF#ROBOTO MONO", "Assets/Fonts/ROBOTOMONO-REGULAR.TTF#ROBOTO MONO") };
                    break;
            }
        }
    }
}