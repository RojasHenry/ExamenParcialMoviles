using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HenryRojasexamen.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public double costoCurso = 1800;
        public double numcuota = 3;
        public double porcentcosto = 0.05;
        public string useractual = "";

        double cuotaVal = 0.0;
        public RegisterPage(string user)
        {
            InitializeComponent();
            useractual = user;
            txtuseractual.Text += user;
            Title = "Registro";
        }

        void btncalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            string valorInicial = txtmontoi.Text.Trim();
            if (!valorInicial.Equals(""))
            {
                double valori = Convert.ToDouble(valorInicial);

                if(valori > 0 && valori < 1800)
                {
                    double cuotaCurso = costoCurso - valori;

                    double coutamen = cuotaCurso / numcuota;

                    cuotaVal = coutamen + (coutamen * porcentcosto);

                    txtpagom.Text = "$ " + Math.Round(cuotaVal, 2);
                }
                else
                {
                    DisplayAlert("Alerta", "Monto incial incorrecto.", "Ok");
                }
            }
            else
            {
                DisplayAlert("Alerta", "Ingrese un monto inicial", "Ok");
            }
        }

        async void btnguardar_Clicked(System.Object sender, System.EventArgs e)
        {
            string nombre = txtunombre.Text.Trim();
            string valorInicial = txtmontoi.Text.Trim();
            string cuota = txtpagom.Text.Trim();

            if(nombre.Equals("") || valorInicial.Equals("") || cuota.Equals(""))
            {
                await DisplayAlert("Alerta", "Complete todos los campos", "Ok");
            }
            else
            {
                double valori = Convert.ToDouble(valorInicial);
        
                if (valori > 0 && valori< 1800)
                {
                    await DisplayAlert("Alerta", "Elemento guardado con exito.", "Ok");

                    await Navigation.PushAsync(new ResumePage(nombre, useractual, cuotaVal));

                    txtunombre.Text = "";
                    txtmontoi.Text = "";
                    txtpagom.Text = "";
                }
                else
                {
                    await DisplayAlert("Alerta", "Monto incial incorrecto.", "Ok");
                }

            }
        }
    }
}
