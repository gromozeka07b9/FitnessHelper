using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutsPage : ContentPage
    {
        List<Workout> _wrk = new List<Workout>();
        string globalKey = "trainings";
        public WorkoutsPage()
        {
            InitializeComponent();
        }

        public List<Workout> WorkoutsList {
            set
            {
                _wrk = value;
            }
            get
            {
                return _wrk;
            }
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            var dt1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            _wrk.Add(new Workout() { Trainer = "Максимова Ольга", Name = "Медитация", TrainDateTime = dt1.AddHours(8), Description = "Расслабление и перезагрузка разума. Позволяет снять стресс." });
            _wrk.Add(new Workout() { Trainer = "Смирнов Сергей", Name = "Functional training", TrainDateTime = dt1.AddHours(10), Description = "Функциональный тренинг - энергоемкое занятие, в основное которого многосуставные упражнения." });
            _wrk.Add(new Workout() { Trainer = "Казанцев Андрей", Name = "L.A.B.", TrainDateTime = dt1.AddHours(16), Description = "Силовая тренировка с акцентов на мышццы ягодиц, ног и пресса." });
            _wrk.Add(new Workout() { Trainer = "Романова Ксения", Name = "Total stretch", TrainDateTime = dt1.AddHours(20), Description = "Основательная тренировка на растяжку: улучшает гибкость, снимает мышечное напряжение." });
            lstWorkouts.ItemsSource = WorkoutsList;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            List<Workout> globalList = new List<Workout>();
            foreach(var item in _wrk)
            {
                if(item.Checked)
                {
                    globalList.Add(new Workout() { Name = item.Name, Description = item.Description, TrainDateTime = item.TrainDateTime, Trainer = item.Trainer });
                }
            }
            if(Application.Current.Properties.ContainsKey(globalKey))
            {
                Application.Current.Properties.Remove(globalKey);
            }

            Application.Current.Properties.Add(globalKey, globalList);
            Navigation.PopModalAsync();
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

        }
    }

    public class Workout
    {
        public string Trainer { get; set; }
        public bool Checked { get; set; }
        public string Name { get; set; }
        public DateTime TrainDateTime { get; set; }
        public string TrainDateTimeString
        {
            get
            {
                return TrainDateTime.ToString("t");
            }
        }
        public string Description { get; set; }
    }
}