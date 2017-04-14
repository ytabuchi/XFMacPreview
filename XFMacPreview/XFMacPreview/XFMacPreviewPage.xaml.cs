using System;
using Xamarin.Forms;

namespace XFMacPreview
{
    public partial class XFMacPreviewPage : ContentPage
    {
        public XFMacPreviewPage()
        {
            InitializeComponent();
        }

        void alertButton_Clicked(object sender, EventArgs e)
        {
            var msg = entry.Text ?? "Someone";
            DisplayAlert("Alert", msg, "OK");
        }
    }
}
