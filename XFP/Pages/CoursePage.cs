using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFP.Pages
{
    class CoursePage : ContentPage
    {
        public CoursePage(PluralsightCourse course)
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(10, 20, 10, 0);
                    break;
                default:
                    Padding = new Thickness(10, 0);
                    break;
            }

            BackgroundColor = Color.Gray;

            this.Title = course.TitleShort;

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
                    Spacing = 10,
                    Children = { titleLabel, authorLabel, descriptionLabel }
                }
            };
        }
    }
}
