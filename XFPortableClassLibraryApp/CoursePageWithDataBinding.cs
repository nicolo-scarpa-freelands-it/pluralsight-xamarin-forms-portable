using System;
using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public class CoursePageWithDataBinding : ContentPage
    {
        public CoursePageWithDataBinding()
        {
            this.SetBinding(ContentPage.TitleProperty, new Binding("TitleShort"));

            var titleLabel = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var authorLabel = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };
            authorLabel.SetBinding(Label.TextProperty, new Binding("Author"));

            var descriptionLabel = new Label
            {
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children = { titleLabel, authorLabel, descriptionLabel }
                }
            };
        }
    }
}
