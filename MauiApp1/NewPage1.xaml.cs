namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
#if IOS
        UIKit.UINavigationController? vc = Platform.GetCurrentUIViewController() as UIKit.UINavigationController;
        //using UIKit, find the UINavigationController
        if (vc != null)
        {
            vc.InteractivePopGestureRecognizer.Enabled = true;
        }
#endif
    }
}