using Android.Graphics;
using Google.Android.Material.Tabs;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Android.Graphics.Color;

namespace MauiApp2.Platforms.Android
{
    internal class ShellTabLayoutAppearanceTrackerEx : ShellTabLayoutAppearanceTracker
    {
        public ShellTabLayoutAppearanceTrackerEx(IShellContext shellContext) : base(shellContext)
        {

        }

        public override void SetAppearance(TabLayout tabLayout, ShellAppearance appearance)
        {
            base.SetAppearance(tabLayout, appearance);
            //tabLayout.SetBackgroundColor(Color.Pink);
        }
    }
}
