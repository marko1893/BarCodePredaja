using BarCode.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BarCode.Views
{
    public partial class AboutPage : ContentPage
    {
        AboutViewModel viewModel;
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new AboutViewModel();

        }
    }
}