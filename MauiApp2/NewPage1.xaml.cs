namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void refreshView_Refreshing(object sender, EventArgs e)
    {
		refreshView.IsRefreshing = true;
		webview.Reload();
		refreshView.IsRefreshing = false;
    }
}