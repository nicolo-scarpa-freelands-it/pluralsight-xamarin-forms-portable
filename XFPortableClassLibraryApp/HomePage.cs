using System.Linq;
using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Pages";

            var button1 = new Button { Text = "Simple Page" };
            button1.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new CoursePage(PluralsightCourse.GetCourseList().First()));
            };

            var button2 = new Button { Text = "Master/Detail" };
            button2.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new CourseMasterDetailPage());
            };

            var button3 = new Button { Text = "Master/Detail (binding)" };
            button3.Clicked += (sender, e) =>
            {
				Navigation.PushAsync(new CourseMasterDetailPageWithDataBinding());
            };

            var button4 = new Button { Text = "" };
            button4.Clicked += (sender, e) =>
            {
            };

            var button5 = new Button { Text = "" };
            button5.Clicked += (sender, e) =>
            {
            };

            Content = new StackLayout
            {
                Children = { button1, button2, button3, button4, button5 }
            };
        }
    }
}

