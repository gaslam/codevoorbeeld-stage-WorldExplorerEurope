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
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldExplorerEurope.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            RegisterViewModel registerViewModel = new RegisterViewModel();
            BindingContext = registerViewModel;
            dataForm.DataObject = registerViewModel.newUser;
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            var name = e.DataFormItem.Name;
            switch (name)
             {
                 case "Email":
                     e.DataFormItem = new DataFormTextItem() { Name = "Email", Editor = "Text", PlaceHolderText = "Enter Email", KeyBoard = Keyboard.Email };
                     e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway", "Assets/Fonts/Raleway-Light.ttf#Raleway"), FontSize = 16 };
                     e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto-Mono", "Assets/Fonts/RobotoMono-Bold.ttf#Roboto-Mono") };

                     break;
                 case "Password":
                     e.DataFormItem = new DataFormTextItem() { Name = "Password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                     e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway", "Assets/Fonts/Raleway-Light.ttf#Raleway"), FontSize = 16 };
                     e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto-Mono", "Assets/Fonts/RobotoMono-Bold.ttf#Roboto-Mono") };
                    break;
                case "PasswordRepeat":
                    e.DataFormItem = new DataFormTextItem() { Name = "Repeat password", Editor = "Password", PlaceHolderText = "Enter Password", KeyBoard = Keyboard.Text };
                    e.DataFormItem.HintLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("Raleway-Light.ttf", "Raleway-Light.ttf#Raleway", "Assets/Fonts/Raleway-Light.ttf#Raleway"), FontSize = 16 };
                    e.DataFormItem.HelperLabelStyle = new LabelStyle() { FontFamily = Device.OnPlatform("RobotoMono-Bold.ttf", "RobotoMono-Bold.ttf#Roboto-Mono", "Assets/Fonts/RobotoMono-Bold.ttf#Roboto-Mono") };
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