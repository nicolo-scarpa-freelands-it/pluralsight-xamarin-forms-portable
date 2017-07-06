using System.Linq;

using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public class CourseMasterDetailPageWithDataBinding : MasterDetailPage
    {
        public CourseMasterDetailPageWithDataBinding()
		{
            Detail = new CoursePageWithDataBinding();

			var listView = new ListView();
			listView.ItemsSource = PluralsightCourse.GetCourseList();
			listView.ItemSelected += (sender, e) =>
			{
				if (e.SelectedItem == null) return;

                Detail.BindingContext = e.SelectedItem;

				IsPresented = false; // hide master page
			};

			Master = new ContentPage
			{
				Title = "Courses",
				Content = listView
			};

            Detail.BindingContext = PluralsightCourse.GetCourseList().First();
        }
    }
}
