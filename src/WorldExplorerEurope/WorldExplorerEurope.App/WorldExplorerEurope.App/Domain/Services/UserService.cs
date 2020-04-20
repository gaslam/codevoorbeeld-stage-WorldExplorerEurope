using System;
using System.Collections.Generic;
using System.Text;
using WorldExplorerEurope.App.Domain.Models;
using Xamarin.Forms;

namespace WorldExplorerEurope.App.Domain.Services
{
    public class UserService
    {

        public void SetUser(User newUser)
        {
            Application.Current.Properties["User"] = newUser;
        }

        public User GetUser()
        {
            if (Application.Current.Properties.ContainsKey("User"))
            {
                return Application.Current.Properties["User"] as User;
            }
            return null;
        }
    }
}
