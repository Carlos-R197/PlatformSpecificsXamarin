using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependecyServicesXamarin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Internals;
using Xamarin.Forms;

[assembly: Dependency(typeof(DependecyServicesXamarin.Droid.Services.DeviceOrientationService))]
namespace DependecyServicesXamarin.Droid.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            var windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 || orientation == SurfaceOrientation.Rotation270;

            if (isLandscape)
                return DeviceOrientation.Landscape;
            else
                return DeviceOrientation.Portrait;
        }
    }
}