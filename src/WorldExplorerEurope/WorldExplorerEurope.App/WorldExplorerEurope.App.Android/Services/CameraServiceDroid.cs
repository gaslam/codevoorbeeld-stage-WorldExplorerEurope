﻿using System;
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
            /*
             * I want to use this code, but it just does not work.
            PermissionStatus status = await CrossPermissions.Current.CheckPermissionStatusAsync<CameraPermission>();
            if (status != PermissionStatus.Granted)
            {
                status = await CrossPermissions.Current.RequestPermissionAsync<CameraPermission>();
                return true;
            }

            if (status == PermissionStatus.Granted)
            {
                return true;
            }
            return false;
            */
            return true;
        }
        /*
        public async Task<MediaFile> TakePicture()
        {
            try
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await App.Current.MainPage.DisplayAlert("Camera not found", "It looks like your camera is not available.\n Restart your device to try again.", "Ok");
                    return null;
                }
                else
                {
                    var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                    {
                        Directory="test",
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
    }*/
    }
}