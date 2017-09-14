using System.Linq;
using Xamarin.Forms;

namespace XFP.Pages
{
    class HomePage : ContentPage
    {
        public HomePage()
        {
            Padding = new Thickness(10, 20, 10, 0);
            Title = "Pages";

            var button1 = new Button {  Text = "Simple Page"};
            button1.Clicked += (o, e) =>
                { 
                Navigation.PushAsync(new CoursePage(PluralsightCourse.GetCourseList().First()));
            };

            var button2 = new Button { Text = "Master/Detail" };
            button2.Clicked += (o, e) =>
            {  Navigation.PushAsync(new CourseMasterDetail());};

            var button3 = new Button { Text = "Master/Detail (binding)" };
            button3.Clicked += (o, e) =>
            {  Navigation.PushAsync(new CourseMasterDetailDB());};

            var button4 = new Button { Text = "Tabbed" };
            button4.Clicked += (o, e) =>
            {
                var page = new TabbedPage
                {
                    Title = "Courses"
                };

                foreach (var course in PluralsightCourse.GetCourseList())
                {
                    var coursePage = new CoursePageDB{
                        BindingContext = course
                    };
                    page.Children.Add(coursePage);
                }

                Navigation.PushAsync(page);
            };

            var button5 = new Button { Text = "" };
            button5.Clicked += (o, e) =>
            {
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { button1, button2, button3, button4, button5 }
            };
        }
    }
}
