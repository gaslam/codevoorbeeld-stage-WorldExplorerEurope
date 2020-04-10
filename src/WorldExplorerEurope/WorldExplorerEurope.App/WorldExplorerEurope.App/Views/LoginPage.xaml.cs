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
        public LoginPage(INavigation navigation)
        {
            InitializeComponent();
            LoginViewModel loginViewModel = new LoginViewModel(navigation);
            loginViewModel.DataForm = dataForm;
            BindingContext = loginViewModel;
            btnLogin.Command = loginViewModel.LoginCommand;
            dataForm.DataObject = loginViewModel.newUser;
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
            SizeChanged += ChangeMainPageSize;
        }

        private void ChangeMainPageSize(object sender, EventArgs e)
        {
            bool portrait = this.Height > this.Width;
            if(portrait == true)
            {
                txtLogin.Margin = new Thickness { Top = 40 };
                txtLogin.FontSize = 80;
            }
            else
            {
                txtLogin.Margin = new Thickness(0, 0, 0, 0);
                txtLogin.FontSize = 60;
            }
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
            {
                case "Email":
                    e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                    e.DataFormItem.HintLabelStyle =  new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway", "Assets/Fonts/RALEWAY-LIGHT.TTF#Raleway"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto-Mono", "Assets/Fonts/RobotoMono-Bold.ttf#Roboto-Mono") };

                    break;
                case "Password":
                    e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway", "Assets/Fonts/RALEWAY-LIGHT.TTF#Raleway"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto-Mono", "Assets/Fonts/RobotoMono-Bold.ttf#Roboto-Mono") };
                    break;
            }
        }
    }
}