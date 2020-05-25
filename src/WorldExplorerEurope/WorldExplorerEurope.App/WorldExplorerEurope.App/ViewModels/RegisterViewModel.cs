using FreshMvvm;
using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.ViewModels.Syncfusion;
using WorldExplorerEurope.App.Pages;
using Xamarin.Forms;
using System.ComponentModel;
using WorldExplorerEurope.API.Services.Interface;

namespace WorldExplorerEurope.App.ViewModels
{
    public class RegisterViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public SfDataForm DataForm;

        public event PropertyChangedEventHandler PropertyChanged;

        private IAPIinterface _apiService;
        public RegisterViewModel()
        {
            _apiService = new APIservice();
        }

        public async override void Init(object initData)
        {
            test = true;
            base.Init(initData);
            this.newUser = new UserRegister();
            DataForm = new SfDataForm();
            DataForm.DataObject = newUser;
            test = false;
        }

        public bool test;

        private UserRegister user;
        public UserRegister newUser
        {
            get { return user; }
            set
            {
                this.user = value;
                ChangeProperty(nameof(newUser));
            }
        }

        private void ChangeProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public ICommand RegisterCommand => new Command(async ()
            =>
        {
            User createdUser = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                BirthDate = newUser.BirthDate,
                Nationality = newUser.Nationality,
                Password = newUser.Password,
                Role = "Visitor",
                IsSpotifyDj = false
            };
            if (DataForm.Validate() == true)
            {
                var request = await _apiService.Post($"{WorldExplorerAPIService.BaseUrl}/users/register", JsonConvert.SerializeObject(createdUser));
                //if (request == null) await App.Current.MainPage.DisplayAlert("Service not reachable!!", "Cannot connect to WorldExplorerService.\n\nCheck your wifi settings or try later to connect!!", "OK");
                if (!request.IsSuccessStatusCode) newUser.ErrorMessage = await request.Content.ReadAsStringAsync();
                else if(!test)
                {
                    var user = JsonConvert.DeserializeObject<User>(await request.Content.ReadAsStringAsync());
                    LocalService userService = new LocalService();
                    userService.SetUser(user);
                    await CoreMethods.PushPageModel<DetailViewModel>(user, false, true);
                }
            }
        });

        //Could not fix this issue, but once everything is structured for freshnvvm it will be fixed.
        public ICommand CancelCommand => new Command(
            async () =>
            {
                await CoreMethods.PopToRoot(true);
            });

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
}
