using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public partial class XFListViewPage2 : ContentPage
    {
        public XFListViewPage2()
        {
            InitializeComponent();

			var topPadding = Device.RuntimePlatform == Device.iOS ? 20 : 0;
			Padding = new Thickness(0, topPadding, 0, 0);

			var classNames = new[] {
				"Building Cross Platform Apps with Xamarin Part 1",
				"Building Cross Platform Apps with Xamarin Part 2",
				"Building Google Glass Apps with c# and Xamarin",
				"Android for .NET Developers"
			};

            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();

            var cell = new DataTemplate(typeof(TextCell));
            cell.SetBinding(TextCell.TextProperty, new Binding("Title"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Author"));
            cell.SetValue(TextCell.TextColorProperty, Color.Red);
            cell.SetValue(TextCell.DetailColorProperty, Color.Yellow);

            listView.ItemTemplate = cell;

            Content = listView;
        }
    }
}
