using System.Linq;
using System.Diagnostics;
using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public partial class XFListViewPage1 : ContentPage
    {
        ListView listView;

        public XFListViewPage1()
        {
            InitializeComponent();

            var topPadding = Device.RuntimePlatform == Device.iOS ? 20 : 0;
            Padding = new Thickness(0, topPadding, 0, 0);

            listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();
            listView.ItemSelected += listViewItemSelectedHandler;

            Content = listView;
        }

        void listViewItemSelectedHandler(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            Debug.WriteLine("Selected: " + e.SelectedItem);

            listView.SelectedItem = null;
        }
    }
}
