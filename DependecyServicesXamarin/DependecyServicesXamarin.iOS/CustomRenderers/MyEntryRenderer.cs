using DependecyServicesXamarin.CustomRenderers;
using DependecyServicesXamarin.iOS.CustomRenderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace DependecyServicesXamarin.iOS.CustomRenderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(72, 109, 219);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}