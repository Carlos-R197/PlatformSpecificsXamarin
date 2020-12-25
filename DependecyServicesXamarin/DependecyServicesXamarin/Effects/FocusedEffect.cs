using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DependecyServicesXamarin.Effects
{
    public class FocusedEffect : RoutingEffect
    {
        public FocusedEffect() : base($"MyCompany.{nameof(FocusedEffect)}")
        {
        }
    }
}
