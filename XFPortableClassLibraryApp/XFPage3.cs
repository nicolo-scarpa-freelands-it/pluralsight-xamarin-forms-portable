using System;
using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public class XFPage3 : ContentPage
    {
        public XFPage3()
        {
            var layout = new RelativeLayout();

            var label1 = new Label
            {
                Text = "This is a line of text"
            };

            layout.Children.Add(label1, Constraint.Constant(0), Constraint.RelativeToParent((parent) =>
            {
                return parent.Height / 2;
            }));

            var label2 = new Label
            {
                Text = "More text over here"
            };

            layout.Children.Add(label2, Constraint.RelativeToView(label1, (RelativeLayout parent, View otherView) =>
            {
                return otherView.X + otherView.Width;
            }), Constraint.RelativeToView(label1, (RelativeLayout parent, View otherView) =>
            {
                return otherView.Y + otherView.Height;
            }));

            Content = layout;
        }
    }
}
