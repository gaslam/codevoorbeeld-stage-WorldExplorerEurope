using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        public EditViewModel EditViewModel;
        public EditPage()
        {
            InitializeComponent();
        }

        public void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
            {
                case "FirstName":
                    e.DataFormItem = new DataFormTextItem() { Name = "FirstName", Editor = "Text", PlaceHolderText = "Enter your firstname", KeyBoard = Keyboard.Email, LabelText = "Firstname" };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
                case "LastName":
                    e.DataFormItem = new DataFormTextItem() { Name = "LastName", Editor = "Text", PlaceHolderText = "Enter your lastname", KeyBoard = Keyboard.Email, LabelText = "Lastname" };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
                case "Nationality":
                    e.DataFormItem = new DataFormTextItem() { Name = "Nationality", Editor = "Text", PlaceHolderText = "Enter your nationality", KeyBoard = Keyboard.Email };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
                case "BirthDate":
                    e.DataFormItem.LabelText = "Date of birth";
                    e.DataFormItem.Editor = "Date";
                    (e.DataFormItem as DataFormDateItem).Format = "dd/MM/yyyy";
                    (e.DataFormItem as DataFormDateItem).MaximumDate = DateTime.Now;
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
                case "Email":
                    e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
            }
        }
    }
}