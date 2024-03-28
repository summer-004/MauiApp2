using Android;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Internal;
using Google.Android.Material.TextView;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Platform;
using Color = Android.Graphics.Color;

namespace MauiApp2.Platforms.Android
{
    class ShellBottomNavViewAppearanceTrackerEx : ShellBottomNavViewAppearanceTracker
    {
        private readonly IShellContext shellContext;

        public ShellBottomNavViewAppearanceTrackerEx(IShellContext shellContext, ShellItem shellItem) : base(shellContext, shellItem)
        {
            this.shellContext = shellContext;
        }

        public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {

            base.SetAppearance(bottomView, appearance);
            if (Shell.GetTabBarIsVisible(shellContext.Shell.CurrentPage))
            {
                var backgroundDrawable = new GradientDrawable();
                backgroundDrawable.SetShape(ShapeType.Rectangle);
                backgroundDrawable.SetCornerRadius(30);
                backgroundDrawable.SetColor(appearance.EffectiveTabBarBackgroundColor.ToPlatform());

                bottomView.SetBackground(backgroundDrawable);
               
                bottomView.SetElevation(0);

                ColorStateList iconColorStates = new ColorStateList(
                new int[][]{
                            new int[]{16842912 },
                            new int[]{-16842912 }
                            }, new int[]{
                            Color.ParseColor("#ff0000"),
                            Color.ParseColor("#F0F0F0")
                });
                bottomView.ItemTextColor = iconColorStates;
                bottomView.ItemIconTintList = iconColorStates;

                //bottomView.Background.SetColorFilter(Color.Transparent, FilterMode.SrcIn);

                var layoutParams = bottomView.LayoutParameters;
                if (layoutParams is ViewGroup.MarginLayoutParams marginLayoutParams)
                {
                    const int margin = 30;
                    marginLayoutParams.BottomMargin = margin;
                    marginLayoutParams.LeftMargin = margin;
                    marginLayoutParams.RightMargin = margin;
                    bottomView.LayoutParameters = layoutParams;
                }
                

                for (int i = 0; i < bottomView?.ChildCount; i++)
                {
                    BottomNavigationMenuView? res =bottomView.GetChildAt(i) as BottomNavigationMenuView;

                    if (res != null)
                    {
                        res.ItemIconSize = 0;
                    }

                    for (int j = 0;j<res?.ChildCount;j++)
                    {
                        var res2 =res.GetChildAt(j) as BottomNavigationItemView;
                        res2?.SetBackgroundColor(Color.Black);
                        for (int k = 0; k < res2?.ChildCount; k++)
                        {
                            var res3 = res2.GetChildAt(k) as BaselineLayout;
                            res3?.SetBackgroundColor(Color.Black);
                            //res3?.Background?.SetColorFilter(Color.Transparent, FilterMode.SrcIn);
                            
                            for (int L = 0; L < res3?.ChildCount; L++)
                            {
                                MaterialTextView res4 = res3.GetChildAt(k) as MaterialTextView;
                                //res4?.SetBackgroundColor(Color.Black);
                                ColorStateList iconColorStates2 = new ColorStateList(
                new int[][]{
                            new int[]{ 1683 }
                            }, new int[]{
                            Color.ParseColor("#000000")
                });
                                var a = new ColorDrawable();
                                a.Alpha = 100;

                                res4.BackgroundTintList = iconColorStates2;
                            }
                        }
                    }
                }
                
                 
            }
        }
    }
}
