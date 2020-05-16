using FreshMvvm;
using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WorldExplorerEurope.API.Services.Interface;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services;
using WorldExplorerEurope.App.Domain.Services.API;
using WorldExplorerEurope.ViewModels.Syncfusion;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class EditViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public SfDataForm DataForm;

        public event PropertyChangedEventHandler PropertyChanged;

        private IAPIinterface _apiService;
        public EditViewModel(User user)
        {
            _apiService = new APIservice();
        }

        public async override void Init(object initData)
        {
            var user = initData as User;

            this.EditedUser = GenerateNewUserEdit(user);
            editUser = user;
            DataForm = new SfDataForm();
            DataForm.DataObject = new UserEdit();
            ActivityIndicator = false;
            base.Init(initData);
        }

        private User editUser;

        private UserEdit GenerateNewUserEdit(User user)
        {
            UserEdit userEdit = new UserEdit()
            {
                BirthDate = user.BirthDate,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Nationality = user.Nationality,
                Token = user.Token
            };
            return userEdit;
        }

        //The user that will be edited
        private UserEdit user;
        public UserEdit EditedUser
        {
            get { return user; }
            set
            {
                this.user = value;
                ChangeProperty(nameof(EditedUser));
            }
        }

        private void ChangeProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private bool activityIndicator;
        public bool ActivityIndicator
        {
            get { return activityIndicator; }
            set
            {
                this.activityIndicator = value;
                ChangeProperty(nameof(ActivityIndicator));
            }
        }

        public ICommand EditCommand => new Command(async ()
            =>
        {
            EditUser();
            if (DataForm.Validate() == true)
            {
                ActivityIndicator = true;
                var request = await _apiService.Put($"{WorldExplorerAPIService.BaseUrl}/users/update/{editUser.Id}", JsonConvert.SerializeObject(editUser), user.Token);
                //if (request == null) await App.Current.MainPage.DisplayAlert("Service not reachable!!", "Cannot connect to WorldExplorerService.\n\nCheck your wifi settings or try later to connect!!", "OK");
                if (!request.IsSuccessStatusCode)
                {
                    EditedUser.ErrorMessage = await request.Content.ReadAsStringAsync();
                    ActivityIndicator = false;
                }
                else
                {
                    var user = JsonConvert.DeserializeObject<User>(await request.Content.ReadAsStringAsync());
                    UserService userService = new UserService();
                    userService.SetUser(user);
                    await CoreMethods.PushPageModel<DetailViewModel>(user, false, true);
                    ActivityIndicator = false;
                }
            }
        });

        private void EditUser()
        {
            editUser.BirthDate = user.BirthDate;
            editUser.Email = user.Email;
            editUser.FirstName = user.FirstName;
            editUser.LastName = user.LastName;
            editUser.Nationality = user.Nationality;
        }

        public ICommand CancelCommand => new Command(
            async () =>
            {
                await CoreMethods.PopPageModel(true);
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
