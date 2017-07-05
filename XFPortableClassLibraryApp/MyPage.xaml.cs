using System;

using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();

            boxViewColor.Color = Color.Blue;
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
			var red = sliderRed.Value;
			var green = sliderGreen.Value;
			var blue = sliderBlue.Value;

			boxViewColor.Color = Color.FromRgb(red, green, blue);
        }
    }
}
