using System;
using System.Linq;
using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public class CourseMasterDetailPage : MasterDetailPage
    {
        public CourseMasterDetailPage()
        {
            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();
            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null) return;

                Detail = new CoursePage(e.SelectedItem as PluralsightCourse);

                IsPresented = false; // hide master page
            };

            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePage(PluralsightCourse.GetCourseList().First());
        }
    }
}
