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

            var classNames = new[] {
                "Building Cross Platform Apps with Xamarin Part 1",
                "Building Cross Platform Apps with Xamarin Part 2",
                "Building Google Glass Apps with c# and Xamarin",
                "Android for .NET Developers"
            };

            var topPadding = Device.RuntimePlatform == Device.iOS ? 20 : 0;

            Padding = new Thickness(0, topPadding, 0, 0);

            listView = new ListView();
            //listView.ItemsSource = classNames;
            listView.ItemsSource = 
                from c in classNames
                    where c.StartsWith("Building", System.StringComparison.CurrentCulture)
                select c;
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
