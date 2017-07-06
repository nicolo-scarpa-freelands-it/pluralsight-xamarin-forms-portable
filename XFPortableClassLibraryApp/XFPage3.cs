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

            var label3 = new Label
            {
                Text = "Last text added"
            };

            layout.Children.Add(label2, Constraint.RelativeToView(label1, (RelativeLayout parent, View otherView) =>
            {
                return otherView.X + otherView.Width;
            }), Constraint.RelativeToView(label1, (RelativeLayout parent, View otherView) =>
            {
                return otherView.Y + otherView.Height;
            }));

            layout.Children.Add(label3, Constraint.RelativeToView(label2, (RelativeLayout parent, View otherView) =>
            {
                return (otherView.X + otherView.Width) - label3.Width; // label3.Width isn't calculated at this point, we have to force the layout to render again once label3 is added (see below)
            }),
            Constraint.RelativeToView(label1, (RelativeLayout parent, View otherView) =>
            {
                return otherView.Y;
            }));
            // Recalculate the layout once label3 has been added to the screen
            label3.SizeChanged += (sender, e) =>
            {
                layout.ForceLayout();
            };

            Content = layout;
        }
    }
}
