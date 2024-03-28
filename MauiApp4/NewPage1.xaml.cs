namespace MauiApp4;

public partial class NewPage1 : ContentPage
{
    public string Text { get; set; } = "";
    public NewPage1(string t)
	{
        Text = t;
		InitializeComponent();
        text.Text = Text;
    }
}