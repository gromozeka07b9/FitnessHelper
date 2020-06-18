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
    public partial class WorkoutsPage : ContentPage
    {
        public WorkoutsPage()
        {
            InitializeComponent();
        }

        public List<Workout> WorkoutsList {
            get
            {
                List<Workout> wrk = new List<Workout>();
                wrk.Add(new Workout() { Trainer = "Максимова Ольга", Name = "Медитация", TrainDateTime = DateTime.Now, Description = "Расслабление и перезагрузка разума. Позволяет снять стресс."});
                wrk.Add(new Workout() { Trainer = "Смирнов Сергей", Name = "Functional training", TrainDateTime = DateTime.Now, Description = "Функциональный тренинг - энергоемкое занятие, в основное которого многосуставные упражнения." });
                wrk.Add(new Workout() { Trainer = "Казанцев Андрей", Name = "L.A.B.", TrainDateTime = DateTime.Now, Description = "Силовая тренировка с акцентов на мышццы ягодиц, ног и пресса." });
                wrk.Add(new Workout() { Trainer = "Романова Ксения", Name = "Total stretch", TrainDateTime = DateTime.Now, Description = "Основательная тренировка на растяжку: улучшает гибкость, снимает мышечное напряжение." });
                return wrk;
            }
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            lstWorkouts.ItemsSource = WorkoutsList;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }

    public class Workout
    {
        public string Trainer { get; internal set; }
        public string Name { get; internal set; }
        public DateTime TrainDateTime { get; internal set; }
        public string TrainDateTimeString
        {
            get
            {
                return TrainDateTime.ToString("t");
            }
        }
        public string Description { get; internal set; }
    }
}