using Newtonsoft.Json;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WorldExplorerEurope.App.Domain.Models;
using WorldExplorerEurope.App.Domain.Services.API;

namespace WorldExplorerEurope.ViewModels.Syncfusion
{
    public class UserRegister : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
                RaisePropertyChanged(nameof(FirstName));
            }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set
            {
                lastname = value;
                RaisePropertyChanged(nameof(LastName));
            }
        }

        private string nationality;
        public string Nationality
        {
            get { return nationality; }
            set
            {
                nationality = value;
                RaisePropertyChanged(nameof(Nationality));
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        private DateTime birthdate;

        [DataType(DataType.Date)]
        public DateTime BirthDate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
                RaisePropertyChanged(nameof(BirthDate));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        private string passwordRepeat;
        public string PasswordRepeat
        {
            get { return passwordRepeat; }
            set
            {
                passwordRepeat = value;
                RaisePropertyChanged(nameof(PasswordRepeat));
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private string errorMessage;
        [Display(AutoGenerateField = false)]
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                this.errorMessage = value;
                RaisePropertyChanged(nameof(ErrorMessage));
            }
        }

        [Display(AutoGenerateField = false)]
        public bool HasErrors
        {
            get { return false; }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            var list = new List<string>();

            if (propertyName.Equals(nameof(FirstName)))
            {
                if (string.IsNullOrEmpty(FirstName) || string.IsNullOrWhiteSpace(FirstName))
                    list.Add("Please, enter a valid name");
            }

            if (propertyName.Equals(nameof(LastName)))
            {
                if(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(LastName))
                    list.Add("Please, enter a valid name");
            }

            if (propertyName.Equals(nameof(Nationality)))
            {
                if (string.IsNullOrEmpty(Nationality))
                    list.Add("Please, enter your nationality");
            }

            if (propertyName.Equals("Email"))
            {
                var validEmail = new EmailAddressAttribute();
                if (!validEmail.IsValid(Email) || string.IsNullOrEmpty(Email))
                    list.Add("Please, enter a valid email");
            }

            if (propertyName.Equals("Password"))
            {
                if (string.IsNullOrEmpty(Password))
                    list.Add("Please, enter a password");

                if (!string.IsNullOrEmpty(Password) && !Regex.IsMatch(Password, "^.*(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).*$"))
                    list.Add("Password must contain at least 1 Upper/lower case letter and a digit.");
                if (Password != null && Password.Length < 10)
                    list.Add("Password must at least have 10 characters.");

                if (PasswordRepeat != Password && PasswordRepeat != null)
                    list.Add("Passwords do not match.");
            }

            if (propertyName.Equals("PasswordRepeat"))
            {
                if (PasswordRepeat != Password)
                    list.Add("Passwords do not match.");
            }

            if (propertyName.Equals(nameof(BirthDate)))
            {
                var currentDate = DateTime.Now;
                if (BirthDate.Date > currentDate.Date)
                {
                    list.Add("Obviously, you cannot be born in the future");
                    return list;
                }
                if (BirthDate.Date.AddYears(12) > currentDate.Date)
                    list.Add("You must be 12 years or older");
            }

            return list;
        }
    }
}
