
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamlTipsAndTricks
{
    public partial class FooterView : StackLayout
    {
        public FooterView(int year)
        {
            InitializeComponent();
            copyRightText.Text = $"Copyright Puppies SA {year}";
        }
    }
}
