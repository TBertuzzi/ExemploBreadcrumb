using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExemploBreadcrumb.Views
{
    public partial class BasePage : ContentPage
    {
        public IList<View> BasePageContent => BaseContent.Children;

        public BasePage()
        {
            InitializeComponent();
        }
    }
}
