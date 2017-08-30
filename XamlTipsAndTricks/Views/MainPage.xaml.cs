using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamlTipsAndTricks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
