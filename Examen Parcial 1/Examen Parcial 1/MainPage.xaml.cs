using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_Parcial_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void botonNum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new adivinarNum());
        }

        private void botonCum_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new adivinarCum());
        }
   
    }
}
