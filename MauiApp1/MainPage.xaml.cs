using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            //var drawingView = new DrawingView
            //{
            //    Lines = new ObservableCollection<IDrawingLine>(),
            //    IsMultiLineModeEnabled = true,
            //    ShouldClearOnFinish = false,
            //    WidthRequest = 500,
            //    HeightRequest = 500,
            //};
            //stacklayout.Add(drawingView);
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new NewPage1());
        //}
        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }


    }

}
