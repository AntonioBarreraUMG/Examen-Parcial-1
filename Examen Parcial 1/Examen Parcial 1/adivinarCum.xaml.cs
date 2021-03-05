using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen_Parcial_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class adivinarCum : ContentPage
    {
        public adivinarCum()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Btn.IsVisible = false;
            Btn1.IsVisible = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Btn1.IsVisible = false;
            Btn2.IsVisible = true;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Btn2.IsVisible = false;
            Btn3.IsVisible = true;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Btn3.IsVisible = false;
            lbl.IsVisible = true;
            Resultado.IsVisible = true;
            Btn4.IsVisible = true;
            Dia.IsVisible = true;
            Mes.IsVisible = true;
            lbl1.IsVisible = true;
            lbl2.IsVisible = true;

        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            var resultado = int.Parse(Resultado.Text);
            var mes = (resultado - 365) % 100;
            var dia = ((resultado - 365) - mes) / 100;
            Dia.Text = dia.ToString();
            Mes.Text = mes.ToString();
        }
    }
}