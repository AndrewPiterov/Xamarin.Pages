using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var button3 = new Button { Text = "" };
            button3.Clicked += (o, e) =>
                {  };

            var button4 = new Button { Text = "" };
            button4.Clicked += (o, e) =>
            {
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
