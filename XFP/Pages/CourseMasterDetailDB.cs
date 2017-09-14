using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFP.Pages
{
    class CourseMasterDetailDB : MasterDetailPage
    {
        public CourseMasterDetailDB()
        {
			var listView = new ListView();
			listView.ItemsSource = PluralsightCourse.GetCourseList();

			listView.ItemSelected += (s, e) =>
			{
				if (e.SelectedItem != null)
				{
                    Detail.BindingContext = e.SelectedItem;
				}
			};

			Master = new ContentPage
			{
				Title = "Courses",
				Content = listView
			};

			Detail = new CoursePageDB();
            Detail.BindingContext = PluralsightCourse.GetCourseList().First();
        }

    }
}
