using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Exercise1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  async void btnSumar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(input1.Text);
            var num2 = Convert.ToDouble(input2.Text);

            var AsnwersResult = num1 + num2;

            Model.Operaciones result = new Model.Operaciones
            {
                resultado = AsnwersResult
            };

            var PageResult = new OperacionesAritmeticas.PageResultados();
            PageResult.BindingContext = result;
            await Navigation.PushAsync(PageResult);

        }


        private async void btnRestar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(input1.Text);
            var num2 = Convert.ToDouble(input2.Text);

            var AsnwersResult = num1 - num2;

            Model.Operaciones result = new Model.Operaciones
            {
                resultado = AsnwersResult
            };

            var PageResult = new OperacionesAritmeticas.PageResultados();
            PageResult.BindingContext = result;
            await Navigation.PushAsync(PageResult);
        }


        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(input1.Text);
            var num2 = Convert.ToDouble(input2.Text);

            var AsnwersResult = num1 * num2;

            Model.Operaciones result = new Model.Operaciones
            {
                resultado = AsnwersResult
            };

            var PageResult = new OperacionesAritmeticas.PageResultados();
            PageResult.BindingContext = result;
            await Navigation.PushAsync(PageResult);
        }


        private async void btnDividir_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(input1.Text);
            var num2 = Convert.ToDouble(input2.Text);

            var AsnwersResult = num1 / num2;

            Model.Operaciones result = new Model.Operaciones
            {
                resultado = AsnwersResult
            };

            var PageResult = new OperacionesAritmeticas.PageResultados();
            PageResult.BindingContext = result;
            await Navigation.PushAsync(PageResult);

        }

    }
}
