using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private string Calcular_Faixa_IMC(double imc)
        {
            try {
                if (imc <= 17)
                {
                    return "Muito Abaixo do Peso 🦴";
                }
                else if (imc <= 18.49)
                {
                    return "Abaixo do Peso 😐";
                }
                else if (imc <= 24.99)
                {
                    return "Peso Normal 👍";
                }
                else if (imc <= 34.99)
                {
                    return "Obesidade I 😐";
                }
                else if (imc <= 39.99)
                {
                    return "Obesidade II 👎";
                }
                else
                {
                    return "Obesidade III 💀";
                }
            } catch (Exception ex) { 
                return ex.Message;
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double altura = double.Parse(entry_altura.Text);
            double peso = double.Parse(entry_peso.Text);

            double imc = peso / Math.Pow(altura, 2);

            imc = Math.Round(imc, 2);

            label_resultados.Text = $"Resultado: {imc}kg/m^2 ({Calcular_Faixa_IMC(imc)})";

            table_valores_referencia.IsVisible = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            entry_altura.Text = string.Empty;
            entry_peso.Text = string.Empty;


            table_valores_referencia.IsVisible= false;
            label_resultados.Text = "Resultado";

        }
    }
}
