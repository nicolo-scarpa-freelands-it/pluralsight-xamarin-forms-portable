using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public partial class XFListViewPage3 : ContentPage
    {
        public XFListViewPage3()
        {
            InitializeComponent();

			var topPadding = Device.RuntimePlatform == Device.iOS ? 20 : 0;
			Padding = new Thickness(0, topPadding, 0, 0);

            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();
            listView.ItemTemplate = new DataTemplate(typeof(CourseCell));

            Content = listView;
        }
    }
}
