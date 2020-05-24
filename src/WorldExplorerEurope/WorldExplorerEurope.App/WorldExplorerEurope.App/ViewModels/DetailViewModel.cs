using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WorldExplorerEurope.App.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.ViewModels
{
    public class DetailViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public async override void Init(object initData)
        {
            var user = initData as User;

            FirstName = user.FirstName;
            LastName = user.LastName;
            Nationality = user.Nationality;
            Email = user.Email;
            BirthDate = user.BirthDate.ToShortDateString();

            currentUser = user;

            base.Init(initData);
        }

        private User currentUser;

        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
            }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set
            {
                lastname = value;
            }
        }

        private string nationality;
        public string Nationality
        {
            get { return nationality; }
            set
            {
                nationality = value;
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        private string birthdate;

        public string BirthDate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }

        //This is only written for the test
        public User GetUser()
        {
            return currentUser;
        }

        public ICommand EditCommand => new Command(async () =>
        {
            await CoreMethods.PushPageModel<EditViewModel>(currentUser, true, true);
        });

        public ICommand CancelCommand => new Command(
           async () =>
           {
               await CoreMethods.PushPageModel<LoginViewModel>();
           });
    }
}
