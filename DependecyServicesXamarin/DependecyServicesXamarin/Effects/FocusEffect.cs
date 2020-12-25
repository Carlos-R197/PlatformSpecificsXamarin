using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DependecyServicesXamarin.Effects
{
    public class FocusEffect : RoutingEffect
    {
        public FocusEffect() : base($"MyCompany.{nameof(FocusEffect)}")
        {
        }
    }
}
