using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarCode.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace BarCode.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        ScanViewModel viewModel;
        
        public ScanPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ScanViewModel();
         
        }

    }
}