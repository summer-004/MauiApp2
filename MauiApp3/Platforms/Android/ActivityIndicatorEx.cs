using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Platforms.Android
{
    public class ActivityIndicatorEx:ActivityIndicatorHandler
    {
        protected override void ConnectHandler(global::Android.Widget.ProgressBar platformView)
        {
            
            base.ConnectHandler(platformView);
        }
    }
}
