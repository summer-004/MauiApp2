using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class LoginViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel() { LoginCommand = new Command(OnLoginClicked); }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
