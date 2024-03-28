using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        [ObservableProperty]
        public bool allowDrop= new();

        [ObservableProperty]
        public string dragItem;

        public MainViewModel()
        {
            allowDrop = true;
            dragItem = "dsc.JPG";
        }

        [RelayCommand]
        public void DragOver(object e)
        {
            var takingImage = e as Image;
            // Get the image source string
            string imageSource = takingImage.Source.ToString();

            // Replace "File: " with an empty string
            //string fileName = imageSource.Replace("File: ", "");

            // Compare the file names
            if (dragItem == imageSource)
            {
                Console.WriteLine("Something cool");
            }
            else
            {
                Console.WriteLine("Incorrect match. Do not change the image source.");
                allowDrop = false;
            }
            //else code
        }
    }
}
