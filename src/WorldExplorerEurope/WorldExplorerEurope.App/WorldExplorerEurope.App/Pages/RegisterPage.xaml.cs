using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.App.ViewModels;
using WorldExplorerEurope.Domain.Models;
using WorldExplorerEurope.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterViewModel registerViewModel;
        public RegisterPage()
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
                case "Password":
                    e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
                case "PasswordRepeat":
                    e.DataFormItem = new DataFormTextItem() { Name = "PasswordRepeat", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text, LabelText = "Repeat password" };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway Light", "/Assets/Fonts/Raleway-Light.ttf#Raleway Light"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto Mono", "/Assets/Fonts/ROBOTOMONO-BOLD.TTF#Roboto Mono") };
                    e.DataFormItem.ValidationLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-ExtraLight.ttf", "Raleway-ExtraLight.ttf#Raleway ExtraLight", "/Assets/Fonts/Raleway-ExtraLight.ttf#Raleway ExtraLight") };
                    break;
            }
        }
    }

    public class SourceProviderExt : SourceProvider
    {
        public override IList GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "Nationality")
            {
                list = GetCountries().Result;
            }
            return list;
        }

        private async Task<List<string>> GetCountries()
        {
            var list = new List<string>();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    string url = $"{WorldExplorerAPIService.BaseUrl}/basic";
                    string response = await httpClient.GetStringAsync(url);
                    if (response == "")
                    {
                        throw new ArgumentException();
                    }
                    var countries = JsonConvert.DeserializeObject<List<Country>>(response);
                    foreach (var country in countries)
                    {
                        list.Add(country.Name);
                    }
                    return list;
                }
            }
            catch
            {
                return list;
            }
        }

    }
}