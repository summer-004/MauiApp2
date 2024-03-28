namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
     

        private void Button_Clicked(object sender, EventArgs e)
        {
            IsBusy = !IsBusy;

#if ANDROID
            var progressLayout = Platform.CurrentActivity?.FindViewById(16908999) as Android.Widget.FrameLayout;
            var progressbar = progressLayout?.GetChildAt(0) as Android.Widget.ProgressBar;

            //when IsBusy is false, progressbar will be removed, will be null. So should make a judgment
            if (progressbar != null)
            {
                // set it to red
                var iconColorStates = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Red);
                progressbar.IndeterminateTintList = iconColorStates;
            }
#endif

        }
    }

}
