using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyShedulePage : ContentPage
    {
        public MyShedulePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new WorkoutsPage());
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            lstCalendarDate.ItemsSource = Dates;
            lstCalendarTime.ItemsSource = Times;
        }

        private List<String> Dates
        {
            get
            {
                string frmt = "ddd dd MMM";
                List<String> dates = new List<string>();
                dates.Add(DateTime.Now.AddDays(-10).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-9).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-8).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-7).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-6).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-4).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-3).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-2).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(-1).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(0).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(1).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(2).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(3).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(4).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(5).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(6).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(7).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(8).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(9).ToString(frmt));
                dates.Add(DateTime.Now.AddDays(10).ToString(frmt));
                return dates;
            }
        }
        private List<String> Times
        {
            get
            {
                List<String> times = new List<string>();
                times.Add("06:00");
                times.Add("07:00");
                times.Add("08:00");
                times.Add("09:00");
                times.Add("10:00");
                times.Add("11:00");
                times.Add("12:00");
                times.Add("13:00");
                times.Add("14:00");
                times.Add("15:00");
                times.Add("16:00");
                times.Add("17:00");
                times.Add("18:00");
                times.Add("19:00");
                times.Add("20:00");
                times.Add("21:00");
                return times;
            }
        }
    }
}