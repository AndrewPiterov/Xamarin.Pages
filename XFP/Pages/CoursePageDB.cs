using Xamarin.Forms;

namespace XFP.Pages
{
    class CoursePageDB : ContentPage
    {
        public CoursePageDB()
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

            //this.Title = course.TitleShort;
            this.SetBinding(Page.TitleProperty, new Binding("TitleShort"));

            var titleLabel = new Label
            {
                //Text = course.Title,
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var authorLabel = new Label
            {
                //Text = course.Author,
                Font = Font.SystemFontOfSize(NamedSize.Small)
            };
            authorLabel.SetBinding(Label.TextProperty, new Binding("Author"));

            var descriptionLabel = new Label
            {
                //Text = course.Description,
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description"));

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
