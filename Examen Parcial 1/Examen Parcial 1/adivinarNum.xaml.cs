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
    public partial class adivinarNum : ContentPage
    {
        public adivinarNum()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var resultado = int.Parse(Resultado.Text);
            var respuesta = (resultado / 10) - 4;
            Respuesta.Text = respuStesta.Toring();
        }
    }
}