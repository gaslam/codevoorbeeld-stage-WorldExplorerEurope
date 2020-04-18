using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorldExplorerEurope.Domain.Models;
using Xamarin.Essentials;

namespace WorldExplorerEurope.App.Domain.Services
{
    public class LocationService
    {
        public async Task<Country> GetLocation()
        {
            try
            {
                var geoRequest = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(geoRequest);
                OpenCageService openCageService = new OpenCageService();
                var country = await openCageService.GetCountry(location.Longitude, location.Latitude);
                return country;
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await App.Current.MainPage.DisplayAlert("Feature not supported", "I'm sorry, but it looks like you'll have to open the page, manually.", "Ok");
                return null;
            }
            catch (FeatureNotEnabledException fneEx)
            {
                await App.Current.MainPage.DisplayAlert("Location not enabled", "To use this feature, turn on your device location.", "Ok");
                return null;
            }
            catch (PermissionException pEx)
            {
                await App.Current.MainPage.DisplayAlert("Access denied", "Please, enable your device location to use this feature.", "Ok");
                return null;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Cannot use this feature, restart the app to try again.", "Ok");
                return null;
            }
            return null;
        }
    }
}
