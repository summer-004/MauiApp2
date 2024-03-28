using MauiApp3.ViewModels;

namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

	private void DropGestureRecognizer_DragOver(object sender, DragEventArgs e)
	{
		var i = FirstImage.Source.ToString();
		var j = e.Data.Image.ToString();
		if (i != j)
		{
			drop.AllowDrop = false;
		}
	}
}