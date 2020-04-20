using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using WorldExplorerEurope.App.Domain.Services;

[assembly: Xamarin.Forms.Dependency(typeof(WorldExplorerEurope.App.Droid.Services.CameraServiceDroid))]
namespace WorldExplorerEurope.App.Droid.Services
{
    public class CameraServiceDroid : ICameraService
    {
        public async Task<bool> CheckAndroidCameraPermissions()
        {
            PermissionStatus camera = await CrossPermissions.Current.CheckPermissionStatusAsync<CameraPermission>();
            PermissionStatus Storage = await CrossPermissions.Current.CheckPermissionStatusAsync<StoragePermission>();
            if (camera != PermissionStatus.Granted)
            {
                camera = await CrossPermissions.Current.RequestPermissionAsync<CameraPermission>();
                return true;
            }
            if (Storage != PermissionStatus.Granted)
            {
                Storage = await CrossPermissions.Current.RequestPermissionAsync<StoragePermission>();
                return true;
            }

            if (camera == PermissionStatus.Granted && Storage == PermissionStatus.Granted)
            {
                return true;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Permissions not granted", "In order to use this feature, enable storage and camera permissions for this app.", "Ok");
                return false;
            }
        }

        public async Task<MediaFile> TakePicture()
        {
            try
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    return null;
                }
                else
                {
                    var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory = "test",
                        SaveToAlbum = true,
                    });

                    return file;
                }
            }
            catch
            {
                return null;
            }
        }
        public async Task<MediaFile> PickPicture()
        {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await App.Current.MainPage.DisplayAlert("Cannot open photo's", "It looks like your photo library is not available.\n Restart your device to try again.", "Ok");
                    return null;
                }
                else
                {
                    var file = await CrossMedia.Current.PickPhotoAsync();

                    if (file == null)
                    {
                        await App.Current.MainPage.DisplayAlert("Photo not found!!", "", "Ok");
                        return null;
                    }
                    return file;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}