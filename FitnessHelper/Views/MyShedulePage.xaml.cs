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
    }
}