using DependecyServicesXamarin.Services;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DependecyServicesXamarin.iOS.Services.DeviceOrientationService))]
namespace DependecyServicesXamarin.iOS.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;

            if (isPortrait)
                return DeviceOrientation.Portrait;
            
            return DeviceOrientation.Landscape;
        }
    }
}