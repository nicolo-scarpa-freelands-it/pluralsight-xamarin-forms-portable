using System;

using Xamarin.Forms;

namespace XFPortableClassLibraryApp
{
    public class CoursePage : ContentPage
    {
        public CoursePage(PluralsightCourse course)
        {
            Title = course.Title;

            var titleLabel = new Label
            {
                Text = course.Title,
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };

            var authorLabel = new Label
            {
                Text = course.Author,
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };

            var descriptionLabel = new Label
            {
                Text = course.Description,
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };

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
